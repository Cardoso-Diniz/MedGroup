USE MedGroup;
GO

INSERT INTO Endereco(Rua,Numero,Bairro,Cidade,Cep)
VALUES ('Alameda Barão','539','Santa Cecilia','SP','01202-001');
GO

INSERT INTO Clinica(idEndereco,NomeDado,CPNJ,RazaoSocial,AberturaHorario,FechamentoHorario)
VALUES ('1','ClinicaCardoso','123456789','Cuidar de pessoas','06:30','22:30');
GO

INSERT INTO Usuario(TituloUsuario)
VALUES ('Adm'),('Medico'),('Paciente');
GO

INSERT INTO UsuarioPossui(idUsuario,Email,Senha)
VALUES ('1','senai@132','senaizap'),
	   ('2','senaiapi@132','senaizap123'),
	   ('3','paciente@gmail.com','senai1234');
GO

INSERT INTO Paciente(idUsuarioPossui,idEndereco,NomePaciente,DataNascimento,Telefone,Rg,Cpf)
VALUES ('1','1','Guilherme','20041107','11982697150','9301929304','45626492836'),
       ('3','1','Ricardo','20040923','11982697160','94329452385','45626436732');
GO

INSERT INTO Medico(idUsuarioPossui,idClinica,idPaciente,NomeMedico,CRM,idUsuario)
VALUES ('2','1','2','Saulo','204SP','2')
GO

INSERT INTO Situacao(Status)
VALUES ('Bem'),
	   ('Mal'),
	   ('Estavel');
GO

INSERT INTO Consulta(idPaciente,idMedico,idSituacao,DataConsulta,DescricaoConsulta)
VALUES ('2','4','1','20211107 15:30','Paciente com dor de cabeça'),
	   ('2','4','1','20211107 16:30','Paciente com dor no corpo')
GO

INSERT INTO Especialidade(NomeEspecialidades)
VALUES ('Acupuntura'), ('Anestesiologia'), ('Angiologia'),('Cardiologia'),
		('Cirurgia Cardiovascular'),('Cirurgia da Mão'),('Cirurgia do Aparelho Digestivo'),
		('Cirurgia Geral'), ('Cirurgia Pediátrica'),('Cirurgia Plástica'),('Cirurgia Torácica'),
		('Cirurgia Vascular'),('Dermatologia'),('Radioterapia'),('Urologia'),('Pediatria'),('Psiquiatria');
GO




SELECT * FROM Endereco;
SELECT * FROM Clinica;
SELECT * FROM Usuario;
SELECT * FROM UsuarioPossui;
SELECT * FROM Paciente;
SELECT * FROM Medico;
SELECT * FROM Situacao;
SELECT * FROM Consulta;
SELECT * FROM Especialidade;