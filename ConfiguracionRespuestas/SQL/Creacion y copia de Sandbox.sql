USE [ArrendamientoInmueble]
go

--drop table [SandBox].[Cat_Tema]
--drop table [SandBox].[Concepto]
--drop table [SandBox].[Respuesta]
--drop SCHEMA SandBox


IF NOT EXISTS (
	SELECT  schema_name
		FROM    information_schema.schemata
		WHERE   schema_name = 'SandBox' )
begin 
	Print 'No existe el SCHEMA SandBox, es necesario crearlo primero en sql management studio';
end
else
begin
	begin try
		begin tran
			IF (EXISTS (SELECT *
				FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'SandBox'
				AND TABLE_NAME = 'Rel_ConceptoRespValor'))
			BEGIN
				PRINT 'DROPing Rel_ConceptoRespValor';
				drop table [SandBox].[Rel_ConceptoRespValor];
			END;
		commit tran;
	end try
	begin catch
		rollback tran
	end catch

	begin try
		begin tran
			IF (EXISTS (SELECT *
				FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'SandBox'
				AND TABLE_NAME = 'Cat_Tema'))
			BEGIN
				PRINT 'DROPing Cat_Tema';
				drop table [SandBox].[Cat_Tema];
			END;

			SET ANSI_NULLS ON;
			SET QUOTED_IDENTIFIER ON;

			CREATE TABLE [SandBox].[Cat_Tema](
				[IdTema] [tinyint] IDENTITY(1,1) NOT NULL,
				[DescripcionTema] [varchar](150) NOT NULL,
				[EstatusRegistro] [bit] NOT NULL,
				[FechaRegistro] [datetime] NOT NULL,
				[Fk_IdUsuarioRegistro] [int] NOT NULL,
			 CONSTRAINT [SB_PK_Cat_Tema] PRIMARY KEY CLUSTERED 
			(
				[IdTema] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			) ON [PRIMARY];
			PRINT 'Cat_Tema created';
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Cat_Tema ON;
			insert into [SandBox].[Cat_Tema] (IdTema, DescripcionTema,EstatusRegistro,FechaRegistro,Fk_IdUsuarioRegistro)
			select IdTema, DescripcionTema,EstatusRegistro,FechaRegistro,Fk_IdUsuarioRegistro from [dbo].[Cat_Tema];
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Cat_Tema OFF;
			Print 'Cat_Tema llenado'
		commit tran;
	end try
	begin catch
		rollback tran
	end catch

	begin try
		begin tran
			IF (EXISTS (SELECT *
				FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'SandBox'
				AND TABLE_NAME = 'Concepto'))
			BEGIN
				PRINT 'DROPing Concepto';
				drop table [SandBox].[Concepto];
			END;

			SET ANSI_NULLS ON;
			SET QUOTED_IDENTIFIER ON;

			CREATE TABLE [SandBox].[Concepto](
				[IdConcepto] [int] IDENTITY(1,1) NOT NULL,
				[DescripcionConcepto] [varchar](500) NOT NULL,
				[DescripcionAlternaConcepto] [varchar](500) NULL,
				[FundamentoLegal] [varchar](max) NULL,
				[Observaciones] [varchar](300) NULL,
				[EstatusRegistro] [bit] NOT NULL,
				[FechaRegistro] [datetime] NOT NULL,
				[Fk_IdUsuarioRegistro] [int] NOT NULL,
			 CONSTRAINT [SB_PK_Concepto] PRIMARY KEY CLUSTERED 
			(
				[IdConcepto] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
			PRINT 'Concepto created';
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Concepto ON
			insert into [SandBox].[Concepto] (IdConcepto, DescripcionConcepto,DescripcionAlternaConcepto,
			FundamentoLegal,Observaciones, EstatusRegistro,FechaRegistro,Fk_IdUsuarioRegistro)
			select IdConcepto, DescripcionConcepto,DescripcionAlternaConcepto,
			FundamentoLegal,Observaciones, EstatusRegistro,FechaRegistro,Fk_IdUsuarioRegistro from [dbo].[Concepto]
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Concepto OFF
			Print 'Concepto llenado'
		commit tran
	end try
	begin catch
		rollback tran
	end catch

	begin try
		begin tran
			IF (EXISTS (SELECT *
				FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'SandBox'
				AND TABLE_NAME = 'Respuesta'))
			BEGIN
				PRINT 'DROPing Respuesta';
				drop table [SandBox].[Respuesta];
			END;

			SET ANSI_NULLS ON;
			SET QUOTED_IDENTIFIER ON;

			CREATE TABLE [SandBox].[Respuesta](
				[IdRespuesta] [int] IDENTITY(1,1) NOT NULL,
				[DescripcionRespuesta] [varchar](70) NOT NULL,
				[Comentario] [varchar](100) NULL,
				[EstatusRegistro] [bit] NOT NULL,
				[Fk_IdUsuarioRegistro] [int] NOT NULL,
				[FechaRegistro] [datetime] NOT NULL,
			 CONSTRAINT [SB_PK_Respuesta] PRIMARY KEY CLUSTERED 
			(
				[IdRespuesta] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			) ON [PRIMARY];
			PRINT 'Respuesta created';
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Respuesta ON;
			insert into [SandBox].[Respuesta] (IdRespuesta, DescripcionRespuesta, Comentario, EstatusRegistro, Fk_IdUsuarioRegistro, FechaRegistro)
			select IdRespuesta, DescripcionRespuesta, Comentario, EstatusRegistro, Fk_IdUsuarioRegistro, FechaRegistro from [dbo].[Respuesta];
			set IDENTITY_INSERT ArrendamientoInmueble.SandBox.Respuesta OFF;
			Print 'Respuesta llenado'

			Print 'Creando Rel_ConceptoRespValor'
			SET ANSI_NULLS ON;
			SET QUOTED_IDENTIFIER ON;
			CREATE TABLE [SandBox].[Rel_ConceptoRespValor](
				[IdConceptoRespValor] [int] IDENTITY(1,1) NOT NULL,
				[Fk_IdInstitucion] [int] NULL,
				[Fk_IdTema] [tinyint] NOT NULL,
				[Fk_IdConcepto] [int] NOT NULL,
				[Fk_IdRespuesta] [int] NOT NULL,
				[NumOrden] [decimal](5, 2) NOT NULL,
				[EsDeterminante] [bit] NOT NULL,
				[ValorRespuesta] [numeric](6, 2) NULL,
				[ValorMinimo] [decimal](10, 2) NOT NULL,
				[ValorMaximo] [decimal](10, 2) NOT NULL,
				[Comentario] [varchar](150) NULL,
				[EstatusRegistro] [bit] NOT NULL,
				[Fk_IdUsuarioRegistro] [int] NOT NULL,
				[FechaRegistro] [datetime] NOT NULL,
			 CONSTRAINT [SB_XPKRel_ConceptoRespValor] PRIMARY KEY CLUSTERED 
			(
				[IdConceptoRespValor] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			) ON [PRIMARY];

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor]  WITH CHECK ADD  CONSTRAINT [R_127] FOREIGN KEY([Fk_IdRespuesta])
			REFERENCES [SandBox].[Respuesta] ([IdRespuesta]);

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor] CHECK CONSTRAINT [R_127];

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor]  WITH CHECK ADD  CONSTRAINT [R_128] FOREIGN KEY([Fk_IdTema])
			REFERENCES [SandBox].[Cat_Tema] ([IdTema]);

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor] CHECK CONSTRAINT [R_128];

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor]  WITH CHECK ADD  CONSTRAINT [R_84] FOREIGN KEY([Fk_IdConcepto])
			REFERENCES [SandBox].[Concepto] ([IdConcepto]);

			ALTER TABLE [SandBox].[Rel_ConceptoRespValor] CHECK CONSTRAINT [R_84];

		commit tran 
	end try
	begin catch
		Print 'Ocurrio un error, aplicando rollback'
		rollback tran
	end catch
end
