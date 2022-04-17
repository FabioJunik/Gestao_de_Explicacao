
/*--------------------------Alunos-------------------------*/

INSERT INTO tbAluno VALUES(NULL, 'Fábio dos Santos','2003-07-04','M','fabiojunik@gmail.com');
INSERT INTO tbAluno VALUES(NULL, 'Manuel Dembo','2003-11-30','M','manueldembo@gmail.com');
INSERT INTO tbAluno VALUES(NULL, 'Marta Da Cruz','2003-02-14','M','martacruz@gmail.com');
INSERT INTO tbAluno VALUES(NULL, 'Tereza Neto','2003-03-23','M','teresaneto@gmail.com');

/*--------------------------Professores-------------------------*/

INSERT INTO tbProfessor VALUES(NULL, 'Ferreira Da Silva','M','ferreira@gmail.com','1993-02-02');
INSERT INTO tbProfessor VALUES(NULL, 'Eva Adão','F','evadao@gmail.com','1985-01-30');
INSERT INTO tbProfessor VALUES(NULL, 'Manuela Martis','F','manutris@gmail.com','1990-02-07');
INSERT INTO tbProfessor VALUES(NULL, 'Joao De Oliveria','M','joaooloveira@gmail.com','1999-11-04');
INSERT INTO tbProfessor VALUES(NULL, 'Antonia Verdura','F','antoniaverd@gmail.com','2000-07-12');


/*-------------------------Disciplina--------------------------*/

INSERT INTO tbDisciplina VALUES (NULL,'Matemática');
INSERT INTO tbDisciplina VALUES (NULL,'Física');
INSERT INTO tbDisciplina VALUES (NULL,'Quimica');
INSERT INTO tbDisciplina VALUES (NULL,'Ingles');
INSERT INTO tbDisciplina VALUES (NULL,'Programação');

/*-------------------------Nivel--------------------------*/

INSERT INTO tbNivel VALUES (NULL,'Básico');
INSERT INTO tbNivel VALUES (NULL,'Intermediario');
INSERT INTO tbNivel VALUES (NULL,'Avançado');

/*-------------------------Sala--------------------------*/

INSERT INTO tbSala VALUES (NULL,'1',20);
INSERT INTO tbSala VALUES (NULL,'1',21);
INSERT INTO tbSala VALUES (NULL,'1',22);
INSERT INTO tbSala VALUES (NULL,'0',23);
INSERT INTO tbSala VALUES (NULL,'1',24);


/*-------------------------Turma--------------------------*/

INSERT INTO tbTurma VALUES(NULL, 'MatBasico', 2500,2,2,'2022-04-30','2022-11-12',15,1,4,1);
INSERT INTO tbTurma VALUES(NULL, 'FisInter', 3000,4,2,'2022-04-30','2022-11-12',10,2,1,2);
INSERT INTO tbTurma VALUES(NULL, 'QuimAvan', 10000,6,3,'2022-04-30','2022-11-12',5,3,5,3);

