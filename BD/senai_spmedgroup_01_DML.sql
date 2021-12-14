USE Medgroup;
GO

INSERT INTO Endereco (rua,numero,cidade,estado,cep)
VALUES ('Av. Bar�o de Limeira','539','S�o Paulo','SP','01202-001');
GO

INSERT INTO Clinica(idEndereco,nomeClinica,cnpj,razaoSocial )
VALUES ('1','Clinica Cardoso','96.435.803/0001-40','Sp MedGroup');
GO

INSERT INTO Especialidade(tituloEspecialidade)
VALUES ('Acupuntura'), ('Anestesiologia'), ('Angiologia'),('Cardiologia'),
		('Cirurgia Cardiovascular'),('Cirurgia da M�o'),('Cirurgia do Aparelho Digestivo'),
		('Cirurgia Geral'), ('Cirurgia Pedi�trica'),('Cirurgia Pl�stica'),('Cirurgia Tor�cica'),
		('Cirurgia Vascular'),('Dermatologia'),('Radioterapia'),('Urologia'),('Pediatria'),('Psiquiatria');
GO

INSERT INTO TipoUsuario(tituloTipoUsuario)
VALUES ('user'),('adm'),('medico');
GO

INSERT INTO Usuario(idTipoUsuario,nomeUsuario,email,senha)
VALUES ('1','Guilherme','paciente@gmail.com','senai1234'),
('2','Ricardo','adm@132','senaizap123'),
('3','Denis Alexandre','medico@gmail.com','senaiapi123');
GO

INSERT INTO Medico(idClinica,idEspecialidade,idUsuario,nomeMed,crm)
VALUES ('1','2','3','Denis Alexandre','50367-SP');
GO

INSERT INTO Paciente(idEndereco,idUsuario,nomePaciente,rg,cpf,dataNasc,telefone)
VALUES ('1','1','Guilherme','50.615.932-2','456.264.926-36','20041107','11 9826-97150');
GO

INSERT INTO Situacao(situacao)
VALUES ('Agendada'),('Realizada'),('Cancelada');
GO

INSERT INTO Consulta(idMedico,idSituacao,idPaciente,dataConsulta,descricao)
VALUES ('1','1','1','20201214 16:00','Paciente com dores de cabeça'),
	   ('1','1','1','20201215 15:30','Paciente com dores na perna'),
	   ('1','1','1','20201216 14:45','Paciente com dores no pescoço');
GO



SELECT * FROM Endereco;
SELECT * FROM Clinica;
SELECT * FROM Especialidade;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuario;
SELECT * FROM Medico;
SELECT * FROM Paciente;
SELECT * FROM Situacao;
SELECT * FROM Consulta;
