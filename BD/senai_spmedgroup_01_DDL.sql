create database MedGroup;

USE MedGroup

CREATE TABLE Endereco(
idEndereco INT PRIMARY KEY IDENTITY,
Rua VARCHAR(200),
Numero VARCHAR(200),
Bairro VARCHAR(200),
Cidade VARCHAR(200),
Cep VARCHAR(200)
);
GO

CREATE TABLE Clinica(
idClinica INT PRIMARY KEY IDENTITY,
idEndereco INT FOREIGN KEY REFERENCES Endereco(idEndereco),
NomeDado VARCHAR(100),
CPNJ VARCHAR(100),
RazaoSocial VARCHAR(500),
AberturaHorario VARCHAR(100),
FechamentoHorario VARCHAR(100),
);
GO

CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
TituloUsuario VARCHAR(200),
);
GO

CREATE TABLE UsuarioPossui(
idUsuarioPossui INT PRIMARY KEY IDENTITY,
idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario),
Email VARCHAR(200),
Senha VARCHAR(200),
);
GO

CREATE TABLE Paciente(
idPaciente INT PRIMARY KEY IDENTITY,
idUsuarioPossui INT FOREIGN KEY REFERENCES UsuarioPossui(idUsuarioPossui),
idEndereco INT FOREIGN KEY REFERENCES Endereco(idEndereco),
NomePaciente VARCHAR(200),
DataNascimento Date,
Telefone VARCHAR(200),
Rg VARCHAR(200),
Cpf VARCHAR(200),
);
GO

CREATE TABLE Medico(
idMedico INT PRIMARY KEY IDENTITY,
idUsuarioPossui INT FOREIGN KEY REFERENCES UsuarioPossui(idUsuarioPossui),
idClinica INT FOREIGN KEY REFERENCES Clinica(idClinica),
idPaciente INT FOREIGN KEY REFERENCES Paciente(idPaciente),
NomeMedico VARCHAR(200),
CRM VARCHAR(200),
);
GO

CREATE TABLE SITUACAO(
idSituacao INT PRIMARY KEY IDENTITY,
Status VARCHAR(200),
);
GO

CREATE TABLE CONSULTA(
idConsulta INT PRIMARY KEY IDENTITY,
idPaciente INT FOREIGN KEY REFERENCES Paciente(idPaciente),
idMedico INT FOREIGN KEY REFERENCES Medico(idMedico),
idSituacao INT FOREIGN KEY REFERENCES Situacao(idSituacao),
);
GO