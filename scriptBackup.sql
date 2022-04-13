/*criação da base de dados original*/
CREATE DATABASE IF NOT EXISTS dbBackupExplicacao;

USE dbBackupExplicacao;

/*criação das tabelas*/
CREATE TABLE tbAdiministrador(
	codAdm INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50),
	password VARCHAR(100)
);

CREATE TABLE tbExplicacao(
	codExplicacao INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(30),
	cod_Adm INT NOT NULL
);

CREATE TABLE tbNormaPagamento(
	codNorma INT PRIMARY KEY AUTO_INCREMENT,
	dataLimite CHAR(2),
	multa FLOAT,
	cod_Explicacao INT NOT NULL
);

CREATE TABLE tbTelefone(
	codTelefone INT PRIMARY KEY AUTO_INCREMENT,
	numero VARCHAR(9) NOT NULL,
	cod_Prof INT,
	cod_Aluno INT,
	cod_Encarregado INT
);

CREATE TABLE tbEndereco(
	codEndereco INT PRIMARY KEY AUTO_INCREMENT,
	municipio VARCHAR(30) NOT NULL,
	bairro VARCHAR(30) NOT NULL,
	rua VARCHAR(30),
	cod_Prof INT,
	cod_Aluno INT
);

CREATE TABLE tbFalta(
	codFalata INT PRIMARY KEY AUTO_INCREMENT,
	dataFalta DATE NOT NULL,
	cod_Turma INT NOT NULL,
	cod_Aluno INT NOT NULL
);

CREATE TABLE tbProfessor(
	codProf INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	sexo ENUM('M','F') NOT NULL,
	email VARCHAR(50) UNIQUE,
	dataNasc DATE NOT NULL
);

CREATE TABLE tbAluno(
	codAluno INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	dataNasc DATE NOT NULL,
	sexo ENUM('M', 'F'),
	email VARCHAR(50) UNIQUE
); 

CREATE TAbLE tbEncarregado(
	codEncarregado INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	sexo ENUM('M', 'F')
);

CREATE TABLE tbAluno_Encarregado(
	cod_Aluno INT NOT NULL,
	cod_Encarregado INT NOT NULL,
	PRIMARY KEY(cod_Aluno, cod_Encarregado)
);

CREATE TABLE tbTurma(
	codTurma INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	preco FLOAT NOT NULL,
	quantProvas INT,
	cargaHoraria INT,
	dataInicio DATE NOT NULL,
	dataFim DATE NOT NULL,
	numMaxAluno INT NOT NULL,
	cod_Nivel INT NOT NULL,
	cod_Sala INT NOT NULL,
	cod_Disciplina INT NOT NULL
);

CREATE TABLE tbHorario(
	codHorario INT PRIMARY KEY AUTO_INCREMENT,
	familia INT NOT NULL,
	diaSemana CHAR(1) NOT NULL,
	horaInicio TIME NOT NULL,
	horaFim TIME NOT NULL
);

CREATE TABLE tbHorario_Turma(
	cod_Horario INT,
	cod_Turma INT,
	familia INT NOT NULL,
	PRIMARY KEY(familia, cod_Turma)
);

CREATE TABLE tbSala(
	codSala INT PRIMARY KEY AUTO_INCREMENT,
	estado CHAR(1) NOT NULL, 
	numero VARCHAR(3) UNIQUE NOT NULL 
);


CREATE TABLE tbNivel(
	codNivel INT PRIMARY KEY AUTO_INCREMENT,
	nivel VARCHAR(20) UNIQUE
);

CREATE TABLE tbDisciplina(
	codDisciplina INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE tbProfessor_Turma(
	cod_Prof INT NOT NULL,
	cod_Turma INT NOT NULL
);

CREATE TABLE tbAluno_Turma(
	codAlunoTurma INT PRIMARY KEY AUTO_INCREMENT, 
	cod_Aluno INT NOT NULL,
	cod_Turma INT NOT NULL
);

CREATE TABLE tbPropina(
	codPropina INT PRIMARY KEY AUTO_INCREMENT, 
	dataPagamento DATE NOT NULL,
	cod_AlunoTurma INT NOT NULL,
	quantMeses INT NOT NULL,
	valor FLOAT NOT NULL
);

CREATE TABLE tbNota(
	codNota INT  PRIMARY KEY AUTO_INCREMENT,
	prova CHAR(1) NOT NULL,
	nota FLOAT NOT NULL,
	cod_AlunoTurma INT NOT NULL
);

CREATE TABLE tbClassificacaoFinal(
	codClassificacaoFinal INT PRIMARY KEY AUTO_INCREMENT,
	cod_AlunoTurma INT NOT NULL,
	media FLOAT NOT NULL
);

/*relacionando as tabelas*/
ALTER TABLE tbExplicacao ADD CONSTRAINT FK_tbAdiministrador_tbExplicacao
FOREIGN KEY(cod_Adm) REFERENCES tbAdiministrador(codAdm);

ALTER TABLE tbNormaPagamento ADD CONSTRAINT FK_tbExplicacao_tbNormaPagamento
FOREIGN KEY(cod_Explicacao) REFERENCES tbExplicacao(codExplicacao); 

ALTER TABLE tbTelefone ADD CONSTRAINT FK_tbProfessor_tbTelefone
FOREIGN KEY(cod_Prof) REFERENCES tbProfessor(codProf);

ALTER TABLE tbTelefone ADD CONSTRAINT FK_tbAluno_tbTelefone
FOREIGN KEY(cod_Aluno) REFERENCES tbAluno(codAluno);

ALTER TABLE tbTelefone ADD CONSTRAINT FK_tbEncarregado_tbTelefone
FOREIGN KEY(cod_Encarregado) REFERENCES tbEncarregado(codEncarregado);

ALTER TABLE tbEndereco ADD CONSTRAINT FK_tbProfessor_tbEndereco
FOREIGN KEY(cod_Prof) REFERENCES tbProfessor(codProf);

ALTER TABLE tbEndereco ADD CONSTRAINT FK_tbAluno_tbEndereco
FOREIGN KEY(cod_Aluno) REFERENCES tbAluno(codAluno);

ALTER TABLE tbAluno_Encarregado ADD CONSTRAINT FK_tbAluno_tbAluno_Encarregado
FOREIGN KEY(cod_Aluno) REFERENCES tbAluno(codAluno);

ALTER TABLE tbAluno_Encarregado ADD CONSTRAINT FK_tbEncarregado_tbAluno_Encarregado
FOREIGN KEY(cod_Encarregado) REFERENCES tbEncarregado(codEncarregado);

ALTER TABLE tbFalta ADD CONSTRAINT FK_tbAluno_tbFalta
FOREIGN KEY(cod_Aluno) REFERENCES tbAluno(codAluno);

ALTER TABLE tbTurma ADD CONSTRAINT FK_tbHorario_tbTurma
FOREIGN KEY(cod_Horario) REFERENCES tbHorario(codHorario);

ALTER TABLE tbTurma ADD CONSTRAINT FK_tbSala_tbTurma
FOREIGN KEY(cod_Sala) REFERENCES tbSala(codSala);

ALTER TABLE tbTurma ADD CONSTRAINT FK_tbNivel_tbTurma
FOREIGN KEY(cod_Nivel) REFERENCES tbNivel(codNivel);

ALTER TABLE tbTurma ADD CONSTRAINT FK_tbDisciplina_tbTurma
FOREIGN KEY(cod_Disciplina) REFERENCES tbDisciplina(codDisciplina);

ALTER TABLE tbProfessor_Turma ADD CONSTRAINT FK_tbProfessor_tbProfessor_Turma
FOREIGN KEY(cod_Prof) REFERENCES tbProfessor(codProf);

ALTER TABLE tbAluno_Turma ADD CONSTRAINT FK_tbAluno_tbAluno_Turma
FOREIGN KEY(cod_Aluno) REFERENCES tbAluno(codAluno);

ALTER TABLE tbAluno_Turma ADD CONSTRAINT FK_tbTurma_tbAluno_Turma
FOREIGN KEY(cod_Turma) REFERENCES tbTurma(codTurma);

ALTER TABLE tbPropina ADD CONSTRAINT FK_tbAluno_turma_tbPropina
FOREIGN KEY(cod_AlunoTurma) REFERENCES tbAluno_Turma(codAlunoTurma);

ALTER TABLE tbNota ADD CONSTRAINT FK_tbAluno_turma_tbNota
FOREIGN KEY(cod_AlunoTurma) REFERENCES tbAluno_Turma(codAlunoTurma);

ALTER TABLE tbClassificacaoFinal ADD CONSTRAINT FK_tbAluno_turma_tbClassificacaoFinal
FOREIGN KEY(cod_AlunoTurma) REFERENCES tbAluno_Turma(codAlunoTurma);
