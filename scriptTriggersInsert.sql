
/*Criação do backup de inserção*/
DELIMITER $

CREATE TRIGGER BK_INSERT_tbAdiministrador
AFTER INSERT ON tbAdiministrador
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbAdiministrador VALUES(NULL, NEW.nome, NEW.password); 
END
$

CREATE TRIGGER BK_INSERT_tbExplicacao
AFTER INSERT ON tbExplicacao
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbExplicacao VALUES(NULL, NEW.nome, NEW.cod_Adm); 
END
$

CREATE TRIGGER BK_INSERT_tbNormaPagamento
AFTER INSERT ON tbNormaPagamento
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbNormaPagamento VALUES(NULL, NEW.dataLimite, NEW.multa, NEW.cod_Explicacao); 
END
$

CREATE TRIGGER BK_INSERT_tbTelefone
AFTER INSERT ON tbTelefone
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbTelefone VALUES(NULL, NEW.numero, NEW.cod_Prof, NEW.cod_Aluno, NEW.cod_Encarregado); 
END
$

CREATE TRIGGER BK_INSERT_tbEndereco
AFTER INSERT ON tbEndereco
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbEndereco VALUES(NULL, NEW.municipio, NEW.bairro, NEW.rua , NEW.cod_Prof, NEW.cod_Aluno); 
END
$

CREATE TRIGGER BK_INSERT_tbFalta
AFTER INSERT ON tbFalta
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbFalta VALUES(NULL, NEW.dataFalta, NEW.cod_Turma, NEW.cod_Aluno); 
END
$

CREATE TRIGGER BK_INSERT_tbProfessor
AFTER INSERT ON tbProfessor
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbProfessor VALUES(NULL, NEW.nome, NEW.sexo, NEW.email, NEW.dataNasc); 
END
$

CREATE TRIGGER BK_INSERT_tbAluno
AFTER INSERT ON tbAluno
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbAluno VALUES(NULL, NEW.nome, NEW.dataNasc, NEW.sexo, NEW.email); 
END
$

CREATE TRIGGER BK_INSERT_tbEncarregado
AFTER INSERT ON tbEncarregado
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbEncarregado VALUES(NULL, NEW.nome, NEW.sexo); 
END
$

CREATE TRIGGER BK_INSERT_tbAluno_Encarregado
AFTER INSERT ON tbAluno_Encarregado
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbAluno_Encarregado VALUES(NEW.cod_Aluno, NEW.cod_Encarregado); 
END
$

CREATE TRIGGER BK_INSERT_tbTurma 
AFTER INSERT ON tbTurma
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbTurma VALUES(NULL, NEW.nome, NEW.preco, NEW.quantProvas, NEW.cargaHoraria, NEW.dataInicio, NEW.dataFim, NEW.numMaxAluno, NEW.cod_Nivel, NEW.cod_Sala, NEW.cod_Disciplina); 
END
$

CREATE TRIGGER BK_INSERT_tbHorario_Turma
AFTER INSERT ON tbHorario_Turma
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbHorario_Turma VALUES(NEW.cod_Horario, NEW.cod_Turma, NEW.familia);
END
$

CREATE TRIGGER BK_INSERT_tbHorario 
AFTER INSERT ON tbHorario
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbHorario VALUES(NULL , NEW.familia, NEW.diaSemana, NEW.horaInicio, NEW.horaFim); 
END
$

CREATE TRIGGER BK_INSERT_tbSala
AFTER INSERT ON tbSala
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbSala VALUES(NULL ,NEW.estado, NEW.numero); 
END
$

CREATE TRIGGER BK_INSERT_tbNivel 
AFTER INSERT ON tbNivel
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbNivel VALUES(NULL ,NEW.nivel); 
END
$

CREATE TRIGGER BK_INSERT_tbDisciplina 
AFTER INSERT ON tbDisciplina
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbDisciplina VALUES(NULL ,NEW.nome); 
END
$

CREATE TRIGGER BK_INSERT_tbProfessor_Turma 
AFTER INSERT ON tbProfessor_Turma
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbProfessor_Turma VALUES(NEW.cod_Prof ,NEW.cod_Turma); 
END
$

CREATE TRIGGER BK_INSERT_tbAluno_Turma 
AFTER INSERT ON tbAluno_Turma
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbAluno_Turma VALUES(NULL, NEW.cod_Aluno ,NEW.cod_Turma); 
END
$

CREATE TRIGGER BK_INSERT_tbPropina 
AFTER INSERT ON tbPropina
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbPropina VALUES(NULL, NEW.dataPagamento ,NEW.cod_AlunoTurma, NEW.quantMeses, NEW.valor); 
END
$

CREATE TRIGGER BK_INSERT_tbNota 
AFTER INSERT ON tbNota
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbNota VALUES(NULL, NEW.prova, NEW.nota, NEW.cod_AlunoTurma); 
END
$

CREATE TRIGGER BK_INSERT_tbClassificacaoFinal 
AFTER INSERT ON tbClassificacaoFinal
FOR EACH ROW 
BEGIN
	INSERT INTO dbBackupExplicacao.tbClassificacaoFinal VALUES(NULL, NEW.cod_AlunoTurma, NEW.media); 
END
$

DELIMITER ;
