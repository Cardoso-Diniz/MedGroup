USE MedGroup;
GO


-- Buscar nomePaciente,data da consulta,Status,Especialides e o nome do medico
SELECT NomePaciente,dataConsulta,Status,NomeEspecialidades, NomeMedico
FROM Situacao S,Clinica W, Medico M,Paciente P,Especialidade E
INNER JOIN Consulta C
ON C.idMedico = C.idMedico

--Buscar idConsulta,nomePaciente,NomeMedico,Especialidades, data da consulta e por fim os status
SELECT c.idConsulta, p.NomePaciente, m.NomeMedico, e.NomeEspecialidades, c.dataConsulta, s.Status
FROM Consulta C
INNER JOIN Medico M
ON C.idMedico = M.idMedico
INNER JOIN Especialidade E
ON E.idEspecialidade = E.idEspecialidade
INNER JOIN Paciente P
ON p.idPaciente = c.idPaciente
INNER JOIN Situacao S 
ON S.idSituacao = c.idSituacao
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