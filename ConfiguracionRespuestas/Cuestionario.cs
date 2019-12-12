using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguracionRespuestas
{
    public partial class Cuestionario : Form
    {
        List<ListTema> temas;
        List<Concepto1> conceptos = new List<Concepto1>();
        List<Respuesta1> respuestas = new List<Respuesta1>();
        ListTema TemaSeleccionado;

        public Cuestionario()
        {
            InitializeComponent();
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
            foreach (var concepto in result)
            {
                conceptos.Add(concepto);
                comboBoxIdConcepto.Items.Add(concepto.IdConcepto + "-" + concepto.DescripcionConcepto);
            }

            var respuestasResult = from respuesta in ctx.Respuesta1
                         select respuesta;
            foreach (var respuesta in respuestasResult)
            {
                respuestas.Add(respuesta);
                comboBoxIdRespuesta.Items.Add(respuesta.DescripcionRespuesta);
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
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {

        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        { 

        }

        private void ShowCuestionario(List<Rel_ConceptoRespValor> cuestionario)
        {
            listBoxPreguntas.Items.Clear();
            foreach(var pregunta in cuestionario)
            {
                listBoxPreguntas.Items.Add(pregunta.NumOrden + " - " + conceptos.Find(c => c.IdConcepto == pregunta.Fk_IdConcepto).DescripcionConcepto);
            }
        }

        private void comboBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemaSeleccionado = temas.Find(t => t.comboBoxIndex == comboBoxTema.SelectedIndex);
            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
            int tema = TemaSeleccionado.IdTema;
            List<Rel_ConceptoRespValor> cuestionario = (from pregunta in ctx.Rel_ConceptoRespValor
                                                        where pregunta.Fk_IdTema == tema
                                                        orderby pregunta.Fk_IdTema, pregunta.NumOrden
                                                        select pregunta).ToList();

            ShowCuestionario(cuestionario);
            labelTEMA.Text = TemaSeleccionado.Descripcion;
        }

        private void buttonInicializaRelaciones_Click(object sender, EventArgs e)
        {
            ArrendamientoInmuebleEntities ctx = new ArrendamientoInmuebleEntities();
            ConfirmarInicializacion confirmarMsg = new ConfirmarInicializacion();
            confirmarMsg.ShowDialog();
            if (confirmarMsg.Respuesta)
            {
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
            }
        }

        private void listBoxPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
