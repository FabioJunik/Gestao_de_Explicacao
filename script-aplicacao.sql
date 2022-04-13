/*Esse script é para salvar dados para gerir o comportamento
da aplicação como dados de configurações...*/

/*Neste momento vou inserir apenas na bd principal*/
CREATE TABLE tbConfiguracao(
	codConfiguracao INT PRIMARY KEY AUTO_INCREMENT,
	codAdmCorrente INT,
	solicitarPalavraPasse CHAR(1)/*0 - NÃO SOLICITAR 1 - SOLICITAR*/	
);

/*ADIMINISTRADOR REI, NUNCA SOLICITAR PALAVRA PASSE*/
INSERT INTO tbConfiguracao VALUES(NULL, 1, '0');