

/*Criando as TRIGGERS de update Backup---------*/

DELIMITER $

CREATE TRIGGER BK_UPDATE_tbAdiministrador
AFTER UPDATE ON tbAdiministrador
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbAdiministrador 
	SET nome = NEW.nome, password = NEW.password
	WHERE codAdm = OLD.codAdm;
END $

CREATE TRIGGER BK_UPDATE_tbExplicacao
AFTER UPDATE ON tbExplicacao
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbExplicacao
	SET nome = NEW.nome, cod_Adm = NEW.cod_adm
	WHERE codExplicacao = OLD.codExplicacao;
END $

CREATE TRIGGER BK_UPDATE_tbNormaPagamento
AFTER UPDATE ON tbNormaPagamento
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbNormaPagamento 
	SET dataLimite = NEW.dataLimite, multa = NEW.multa, cod_Explicacao = NEW.cod_Explicacao
	WHERE codNorma = OLD.codNorma;
END $

CREATE TRIGGER BK_UPDATE_tbTelefone
AFTER UPDATE ON tbTelefone
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbTelefone 
	SET numero = NEW.numero, cod_Prof = NEW.cod_Prof, 
	cod_Aluno = NEW.cod_Aluno, cod_Encarregado = NEW.cod_Encarregado
	WHERE codTelefone = OLD.codTelefone;
END $

CREATE TRIGGER BK_UPDATE_tbEndereco
AFTER UPDATE ON tbEndereco
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbEndereco
	SET municipio = NEW.municipio, bairro = NEW.bairro,
	rua = NEW.rua,cod_Prof = NEW.cod_Prof, cod_Aluno = NEW.cod_Aluno
	WHERE codEndereco = OLD.codEndereco;
END $

CREATE TRIGGER BK_UPDATE_tbFalta
AFTER UPDATE ON tbFalta
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbFalta
	SET dataFalta = NEW.dataFalta, cod_Turma = NEW.cod_Turma, cod_Aluno = NEW.cod_Aluno
	WHERE codFalta = OLD.codFalta;
END $

CREATE TRIGGER BK_UPDATE_tbProfessor
AFTER UPDATE ON tbProfessor
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbProfessor
	SET nome = NEW.nome, sexo = NEW.sexo, email = NEW.email, dataNasc = NEW.dataNasc
	WHERE codProf = OLD.codProf;
END $

CREATE TRIGGER BK_UPDATE_tbAluno
AFTER UPDATE ON tbAluno
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbAluno
	SET nome = NEW.nome, dataNasc =  NEW.dataNasc, sexo = NEW.sexo, email = NEW.email
	WHERE codAluno = OLD.codAluno;
END $

CREATE TRIGGER BK_UPDATE_tbEncarregado
AFTER UPDATE ON tbEncarregado
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbEncarregado
	SET nome = NEW.nome, sexo = NEW.sexo
	WHERE codEncarregado = OLD.codEncarregado;
END $

CREATE TRIGGER BK_UPDATE_tbAluno_Encarregado
AFTER UPDATE ON tbAluno_Encarregado
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbAluno_Encarregado
	SET cod_Aluno = NEW.cod_Aluno, cod_Encarregado = NEW.cod_Encarregado
	WHERE cod_Aluno = OLD.cod_Aluno AND cod_Encarregado = OLD.cod_Encarregado;
END $

CREATE TRIGGER BK_UPDATE_tbTurma
AFTER UPDATE ON tbTurma
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbTurma 
	SET nome = NEW.nome, preco = NEW.preco, quantProvas = NEW.quantProvas, cargaHoraria = NEW.cargaHoraria,
	dataInicio = NEW.dataInicio, dataFim = NEW.dataFim, numMaxAluno = NEW.numMaxAluno, cod_Nivel= NEW.cod_Nivel,
	cod_Sala = NEW.cod_Sala, cod_Disciplina = NEW.cod_Disciplina
	WHERE codTurma = OLD.codTurma;
END $

CREATE TRIGGER BK_UPDATE_tbHorario_Turma 
AFTER UPDATE ON tbHorario_Turma
FOR EACH ROW 
BEGIN
	UPDATE dbBackupExplicacao.tbHorario_Turma 
	SET cod_Turma = NEW.cod_Turma, cod_Horario = NEW.cod_Horario, familia = NEW.familia
	WHERE cod_Turma = OLD.cod_Turma AND cod_Horario = OLD.cod_Horario;
END
$

CREATE TRIGGER BK_UPDATE_tbSala
AFTER UPDATE ON tbSala
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbSala 
	SET estado = NEW.estado, numero = NEW.numero
	WHERE codSala = OLD.codSala;
END $

CREATE TRIGGER BK_UPDATE_tbHorario
AFTER UPDATE ON tbHorario
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbHorario
	SET diaSemana = NEW.diaSemana,horaInicio = NEW.horaInicio, horaFim = NEW.horaFim, familia = NEW.familia
	WHERE codHorario = OLD.codHorario;
END $

CREATE TRIGGER BK_UPDATE_tbNivel
AFTER UPDATE ON tbNivel
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbNivel
	SET nivel = NEW.nivel
	WHERE codNivel = OLD.codNivel;
END $

CREATE TRIGGER BK_UPDATE_tbDisciplina
AFTER UPDATE ON tbDisciplina
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbDisciplina
	SET nome = NEW.nome
	WHERE codDisciplina = codDisciplina;
END $

CREATE TRIGGER BK_UPDATE_tbProfessor_Turma
AFTER UPDATE ON tbProfessor_Turma
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbProfessor_Turma 
	SET cod_Prof = NEW.cod_Prof, cod_Turma = NEW.cod_Turma
	WHERE cod_Prof = OLD.cod_Prof AND cod_Turma = OLD.cod_Turma;
END $

CREATE TRIGGER BK_UPDATE_tbAluno_Turma
AFTER UPDATE ON tbAluno_Turma
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbAluno_Turma 
	SET cod_Aluno = NEW.cod_Aluno, cod_Turma = NEW.cod_Turma
	WHERE cod_Aluno = OLD.cod_Aluno AND cod_Turma = OLD.cod_Turma;
END $

CREATE TRIGGER BK_UPDATE_tbPropina
AFTER UPDATE ON tbPropina
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbPropina 
	SET quantMeses = NEW.quantMeses, valor = NEW.valor, dataPagamento = NEW.dataPagamento,
	cod_AlunoTurma = NEW.cod_AlunoTurma
	WHERE codPropina = OLD.codPropina;
END $

CREATE TRIGGER BK_UPDATE_tbNota
AFTER UPDATE ON tbNota
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbNota
	SET prova = NEW.prova,nota = NEW.nota,cod_AlunoTurma = NEW.cod_AlunoTurma
	WHERE codNota = OLD.codNota;
END $

CREATE TRIGGER BK_UPDATE_tbClassificacaoFinal
AFTER UPDATE ON tbClassificacaoFinal
FOR EACH ROW
BEGIN	
	UPDATE dbBackupExplicacao.tbClassificacaoFinal
	SET cod_AlunoTurma = NEW.cod_AlunoTurma, media = NEW.media
	WHERE codClassificacaoFinal = OLD.codClassificacaoFinal;
END $

	
DELIMITER ;