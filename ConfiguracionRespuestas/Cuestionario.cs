using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguracionRespuestas
{

    public partial class Cuestionario : Form
    {
        class MyConcepto
        {
            public int Indice;
            public Concepto1 concepto1;
        }

        List<ListTema> temas = new List<ListTema>();
        List<MyConcepto> conceptos = new List<MyConcepto>();
        List<Respuesta1> respuestas = new List<Respuesta1>();
        List<Rel_ConceptoRespValor1> ListaPreguntasTema = new List<Rel_ConceptoRespValor1>();
        ListTema TemaSeleccionado;
        
        private Nullable<int> Reg_IdInstitucion
        {
            get
            {
                if (textBoxIdInstitucion.Text.Equals("NULL"))
                    return null;
                else
                    return int.Parse(textBoxIdInstitucion.Text);
            }
            set { textBoxIdInstitucion.Text = value == null ? "NULL" :  value.ToString(); }
        }

        private int Reg_IdTema
        {
            get
            {
                if (labelTEMA.Text.Equals(""))
                    return -1;
                else
                    return temas.Find(t => t.Descripcion.Equals(labelTEMA.Text)).IdTema;
            }
            set { labelTEMA.Text = temas.Find(t => t.IdTema == value).Descripcion;  }
        }

        private int Reg_IdConcepto
        {
            get
            {
                if (comboBoxIdConcepto.SelectedIndex == -1)
                    return -1;
                else
                    return conceptos.Find(c => c.concepto1.DescripcionConcepto.Equals(GetSItem(comboBoxIdConcepto.SelectedText))).concepto1.IdConcepto;
            }
            set
            {
                comboBoxIdConcepto.SelectedIndex = conceptos.Find(r => r.concepto1.IdConcepto == value).Indice;
            }
        }

        private int Reg_IdRespuesta
        {
            get
            {
                if (comboBoxIdRespuesta.SelectedIndex == -1)
                    return -1;
                else
                    return respuestas.Find(r => r.DescripcionRespuesta.Equals(comboBoxIdRespuesta.SelectedText)).IdRespuesta;
            }
            set { comboBoxIdRespuesta.SelectedIndex = comboBoxIdRespuesta.Items.IndexOf(respuestas.Find(r => r.IdRespuesta == value).DescripcionRespuesta); }
        }

        private decimal Reg_NumOrden
        {
            get
            {
                if (textBoxNumOrden.Text.Equals(""))
                    return (decimal)-1.0;
                else
                    return Convert.ToDecimal(textBoxNumOrden.Text);
            }
            set { textBoxNumOrden.Text = value.ToString(); }
        }

        private bool Reg_EsDeterminante
        {
            get
            {
                if (comboBoxEsDeterminante.SelectedIndex == -1)
                    return true;
                else
                {
                    if (comboBoxEsDeterminante.SelectedText.Equals("True"))
                        return true;
                    else
                        return false;
                }
            }
            set { comboBoxEsDeterminante.SelectedIndex = comboBoxEsDeterminante.Items.IndexOf(value); }
        }

        private Nullable<decimal> Reg_ValorRespuesta
        {
            get
            {
                if (textBoxValorRespuesta.Text.Equals("NULL"))
                    return null;
                else
                    return Convert.ToDecimal(textBoxValorRespuesta.Text);
            }
            set { textBoxValorRespuesta.Text = value == null ? "NULL" : value.ToString(); }
        }

        private decimal Reg_ValorMinimo
        {
            get
            {
                if (textBoxValorMinimo.Text.Equals(""))
                    return (decimal)-1.0;
                else
                    return Convert.ToDecimal(textBoxValorMinimo.Text);
            }
            set { textBoxValorMinimo.Text = value.ToString(); }
        }

        private decimal Reg_ValorMaximo
        {
            get
            {
                if (textBoxValorMaximo.Text.Equals(""))
                    return (decimal)-1.0;
                else
                    return Convert.ToDecimal(textBoxValorMaximo.Text);
            }
            set { textBoxValorMaximo.Text = value.ToString(); }
        }

        private String Reg_Comentario
        {
            get
            {
                return textBoxComentario.Text.Equals("NULL") ? "" : textBoxComentario.Text;
            }
            set
            {
                textBoxComentario.Text = value == null ? "NULL" : value;
            }
        }

        private bool Reg_EstatusRegistro
        {
            get
            {
                if (comboBoxEstatusRegistro.SelectedIndex == -1)
                    return true;
                else
                {
                    if (comboBoxEstatusRegistro.SelectedText.Equals("True"))
                        return true;
                    else
                        return false;
                }
            }
            set { comboBoxEstatusRegistro.SelectedIndex = comboBoxEstatusRegistro.Items.IndexOf(value); }
        }

        private int Reg_IdUsuarioRegistro
        {
            get
            {
                if (comboBoxIdUsuarioRegistro.SelectedText.Equals(""))
                    return 1;
                else
                    return int.Parse(comboBoxIdUsuarioRegistro.SelectedText);
            }
            set { comboBoxIdUsuarioRegistro.SelectedIndex = comboBoxIdUsuarioRegistro.Items.IndexOf(value); }
        }

        private System.DateTime Reg_FechaRegistro
        {
            get
            {
                if (labelFechaRegistro.Text.Equals("Fecha Registro") ||
                    labelFechaRegistro.Text.Equals(""))
                    return DateTime.Now;
                else
                    return Convert.ToDateTime(labelFechaRegistro.Text);
            }
            set { labelFechaRegistro.Text = value.ToLongDateString(); }
        }

        private void InicializaApp()
        {
            temas.Clear();
            conceptos.Clear();
            respuestas.Clear();
            TemaSeleccionado = null;

            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();

            temas = (from tema in ctx.Cat_Tema1
                     select new ListTema { IdTema = tema.IdTema, Descripcion = tema.DescripcionTema }).ToList();
            int comboBoxIndex = 0;
            foreach (ListTema tema in temas)
            {
                tema.comboBoxIndex = comboBoxIndex++;
                comboBoxTema.Items.Add(tema.Descripcion);
            }

            var result = from concepto in ctx.Concepto1
                         select concepto;
            int ConceptoIndice = 0;
            foreach (var concepto in result)
            {
                conceptos.Add(new MyConcepto {Indice = ConceptoIndice++, concepto1 = concepto });
                comboBoxIdConcepto.Items.Add(concepto.IdConcepto + " - " + concepto.DescripcionConcepto);
            }

            var respuestasResult = from respuesta in ctx.Respuesta1
                                   select respuesta;
            foreach (var respuesta in respuestasResult)
            {
                respuestas.Add(respuesta);
                comboBoxIdRespuesta.Items.Add(respuesta.DescripcionRespuesta);
            }

            var EsDeterminante = (from pregunta in ctx.Rel_ConceptoRespValor1
                                   select pregunta.EsDeterminante).Distinct();
            foreach (bool estatus in EsDeterminante)
            {
                comboBoxEsDeterminante.Items.Add(estatus);
            }

            var EstatusRegistro = (from pregunta in ctx.Rel_ConceptoRespValor1
                                   select pregunta.EstatusRegistro).Distinct();
            foreach (bool estatus in EstatusRegistro)
            {
                comboBoxEstatusRegistro.Items.Add(estatus);
            }

            var IdUsuario = (from pregunta in ctx.Rel_ConceptoRespValor1
                             select pregunta.Fk_IdUsuarioRegistro).Distinct();
            foreach (int usr in IdUsuario)
            {
                comboBoxIdUsuarioRegistro.Items.Add(usr);
            }
            listBoxPreguntas.HorizontalScrollbar = true;
            
            labelTEMA.Text = "";
            ctx.Dispose();
        }

        public Cuestionario()
        {
            InitializeComponent();
            InicializaApp();
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {

        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        { 

        }

        private void ShowCuestionario(List<Rel_ConceptoRespValor1> cuestionario)
        {
            ListaPreguntasTema.Clear();
            listBoxPreguntas.Items.Clear();
            foreach(var pregunta in cuestionario)
            {
                ListaPreguntasTema.Add(pregunta);
                listBoxPreguntas.Items.Add(pregunta.NumOrden + " - " + conceptos.Find(c => c.concepto1.IdConcepto == pregunta.Fk_IdConcepto).concepto1.DescripcionConcepto);
            }
        }

        private void comboBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemaSeleccionado = temas.Find(t => t.comboBoxIndex == comboBoxTema.SelectedIndex);
            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
            int tema = TemaSeleccionado.IdTema;
            List<Rel_ConceptoRespValor1> cuestionario = (from pregunta in ctx.Rel_ConceptoRespValor1
                                                        where pregunta.Fk_IdTema == tema
                                                        orderby pregunta.Fk_IdTema, pregunta.NumOrden
                                                        select pregunta).ToList();

            ShowCuestionario(cuestionario);
            labelTEMA.Text = TemaSeleccionado.Descripcion;
            ctx.Dispose();
        }

        private void buttonInicializaRelaciones_Click(object sender, EventArgs e)
        {
            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
            ConfirmarInicializacion confirmarMsg = new ConfirmarInicializacion();
            confirmarMsg.ShowDialog();
            if (confirmarMsg.Respuesta)
            {
                ctx.InicializaSandBox();
                int IdRelacion = 0;
                List<byte> temas = (from tema in ctx.Cat_Tema1 select tema.IdTema).Distinct().ToList();
                foreach (byte i in temas)
                {
                    labelInfo.Text = "Tema " + i;
                    var cuestionario = from pregunta in ctx.Rel_ConceptoRespValor
                                       where pregunta.Fk_IdTema == i
                                       orderby pregunta.Fk_IdTema, pregunta.NumOrden
                                       select pregunta;

                    foreach (var pregunta in cuestionario)
                    {
                        labelInfo.Text = pregunta.IdConceptoRespValor + " " + pregunta.Fk_IdTema + " " +
                            pregunta.Fk_IdConcepto + " " + pregunta.Fk_IdRespuesta + " " + pregunta.NumOrden;

                        ctx.Rel_ConceptoRespValor1.Add(new ConfiguracionRespuestas.Rel_ConceptoRespValor1
                        {
                            IdConceptoRespValor = IdRelacion++,
                            Fk_IdInstitucion = pregunta.Fk_IdInstitucion,
                            Fk_IdTema = pregunta.Fk_IdTema,
                            Fk_IdConcepto = pregunta.Fk_IdConcepto,
                            Fk_IdRespuesta = pregunta.Fk_IdRespuesta,
                            NumOrden = pregunta.NumOrden,
                            EsDeterminante = pregunta.EsDeterminante,
                            ValorRespuesta = pregunta.ValorRespuesta,
                            ValorMinimo = pregunta.ValorMinimo,
                            ValorMaximo = pregunta.ValorMaximo,
                            Comentario = pregunta.Comentario,
                            EstatusRegistro = pregunta.EstatusRegistro,
                            Fk_IdUsuarioRegistro = pregunta.Fk_IdUsuarioRegistro,
                            FechaRegistro = pregunta.FechaRegistro,
                        });
                    }
                }
                ctx.SaveChanges();
                ctx.Dispose();
                InicializaApp();
            }
        }

        private void listBoxPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rel_ConceptoRespValor1 pregunta = ListaPreguntasTema[listBoxPreguntas.SelectedIndex];
            Reg_IdInstitucion = pregunta.Fk_IdInstitucion;
            Reg_IdTema = pregunta.Fk_IdTema;
            Reg_IdConcepto = pregunta.Fk_IdConcepto;
            Reg_IdRespuesta = pregunta.Fk_IdRespuesta;
            Reg_NumOrden = pregunta.NumOrden;
            Reg_EsDeterminante = pregunta.EsDeterminante;
            Reg_ValorRespuesta = pregunta.ValorRespuesta;
            Reg_ValorMinimo = pregunta.ValorMinimo;
            Reg_ValorMaximo = pregunta.ValorMaximo;
            Reg_Comentario = pregunta.Comentario;
            Reg_EstatusRegistro = pregunta.EstatusRegistro;
            Reg_IdUsuarioRegistro = pregunta.Fk_IdUsuarioRegistro;
            Reg_FechaRegistro = pregunta.FechaRegistro;
        }

        private void ClearRegistro()
        {

        }

        private string GetSItem(string item)
        {
            return Regex.Replace(item,@"\d(.){0,1}\d* - ","");
        }
    }
}
