CREATE DATABASE bancocunha

-- SCRIPT CRIAR BANCO
CREATE TABLE BANCO
(ID_BANCO INT NOT NULL AUTO_INCREMENT
,COD_BANCO char(3) NOT NULL
,NOME_BANCO VARCHAR(100) NOT NULL
,PRIMARY KEY(ID_BANCO)
);

-- CLIENTE
CREATE TABLE PESSOA
( ID_PESSOA INT NOT NULL AUTO_INCREMENT
,NOME_PESSOA VARCHAR(80) NOT NULL
,DOCUMENTO_PESSOA VARCHAR(14) NOT NULL 
,TIPO_PESSOA CHAR(1) NOT NULL
, PRIMARY KEY(ID_PESSOA)
);

-- CONTA 
CREATE TABLE CONTA
( ID_CONTA INT NOT NULL AUTO_INCREMENT
,NUMERO_CONTA INT NOT NULL
,DATA_ABERTURA DATETIME NOT NULL
,ID_BANCO INT NOT NULL
,ID_PESSOA INT NOT NULL
,NUM_AGENCIA VARCHAR(4) NOT NULL
, PRIMARY KEY(ID_CONTA)
,FOREIGN KEY (ID_BANCO) REFERENCES BANCO(ID_BANCO)
,FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA (ID_PESSOA)
);


-- PROCEDURE INSERIR PESSOA
DELIMITER $$
ALTER PROCEDURE INSERIR_PESSOA 
( p_ID_PESSOA INT
,p_NOME_PESSOA VARCHAR(80)
,p_DOCUMENTO_PESSOA VARCHAR(14)
,p_TIPO_PESSOA CHAR(1)
)
BEGIN

INSERT INTO PESSOA(NOME_PESSOA,DOCUMENTO_PESSOA,TIPO_PESSOA) VALUES(
P_NOME_PESSOA,P_DOCUMENTO_PESSOA,P_TIPO_PESSOA);
END $$

DELIMITER ;
-- PROCEDURE INSERIR PESSOA



CREATE TABLE SALDO_PESSOA
(
ID_SALDO INT NOT NULL AUTO_INCREMENT,
ID_PESSOA INT NOT NULL,
VALOR_SALDO DECIMAL(10,2),
ID_CONTA INT,
NUMERO_CONTA INT,
NUM_AGENCIA VARCHAR(4)

, PRIMARY KEY(ID_SALDO)
,FOREIGN KEY (ID_PESSOA) REFERENCES PESSOA(ID_PESSOA)
,FOREIGN KEY (ID_CONTA) REFERENCES CONTA(ID_CONTA)
);



------------------
DELIMITER $$
CREATE DEFINER=`elton`@`localhost` PROCEDURE `prc_MovBancaria`( 
 p_tipo_movimentacao char(1) 
,p_valor_movimentacao decimal(10,2) 
,p_data_movimentacao datetime 
,p_numero_agencia_origem varchar(4)
,p_numero_conta_origem int
,p_numero_agencia_destino varchar(4) 
,p_numero_conta_destino int 
,p_autenticacao_movimentacao varchar(50)

)
BEGIN
DECLARE p_saldo_origem decimal(10,2);

SET p_saldo_origem = (SELECT VALOR_SALDO FROM SALDO_PESSOA where num_agencia=p_numero_agencia_origem and numero_conta=p_numero_conta_origem);


insert into movimentacao_bancaria (tipo_movimentacao,valor_movimentacao,data_movimentacao,numero_agencia,numero_conta,autenticacao_movimentacao)
values (p_tipo_movimentacao,p_valor_movimentacao,p_data_movimentacao,p_numero_agencia_origem,p_numero_conta_origem,p_autenticacao_movimentacao);
SELECT P_SALDO_ORIGEM;
END