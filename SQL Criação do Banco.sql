-- Criação e Seleção do Banco
DROP DATABASE IF EXISTS gerenciador_igreja;
CREATE DATABASE gerenciador_igreja;
USE gerenciador_igreja;

-- Criação das Tabelas
DROP TABLE if exists status_pendencias;
CREATE TABLE status_pendencias(
	id_status CHAR(2) NOT NULL PRIMARY KEY,
    descricao varchar(15) NOT NULL
);

DROP TABLE if exists status_usuarios;
CREATE TABLE status_usuarios(
	id_status CHAR(2) NOT NULL PRIMARY KEY,
    descricao varchar(15) NOT NULL
);

DROP TABLE if exists status_membros;
CREATE TABLE status_membros(
	id_status CHAR(2) NOT NULL PRIMARY KEY,
    descricao varchar(15) NOT NULL
);

DROP TABLE IF EXISTS urgencias;
CREATE TABLE urgencias(
	id_urgencia INTEGER NOT NULL PRIMARY KEY,
    descricao VARCHAR(50) NOT NULL
);

DROP TABLE IF EXISTS setores;
CREATE TABLE setores(
	id_setor CHAR(2) NOT NULL PRIMARY KEY,
    descricao VARCHAR(25) NOT NULL
);

DROP TABLE IF EXISTS funcoes;
CREATE TABLE funcoes (
	id_funcao INTEGER PRIMARY KEY,
    descricao varchar(50) NOT NULL
);

DROP TABLE IF EXISTS tipos_financas;
CREATE TABLE tipos_financas(
	id_tipo CHAR(2) NOT NULL PRIMARY KEY,
	descricao VARCHAR(25) NOT NULL
);

DROP TABLE IF EXISTS categorias_financas;
CREATE TABLE categorias_financas(
	id_categoria CHAR(2) NOT NULL PRIMARY KEY,
	id_tipo CHAR(2) NOT NULL,
	descricao VARCHAR(25) NOT NULL,

	FOREIGN KEY(id_tipo) REFERENCES tipos_financas(id_tipo)
);

DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios(

	nome_usuario varchar(20) NOT NULL PRIMARY KEY,
    senha varchar(128) NOT NULL,
    id_setor char(2) NOT NULL,
	status_usuario CHAR(2) NOT NULL,
    ultimo_acesso DATETIME,
    
    FOREIGN KEY (id_setor) REFERENCES setores(id_setor),
    FOREIGN KEY (status_usuario) REFERENCES status_usuarios(id_status)
);

DROP TABLE IF EXISTS membros;
CREATE TABLE membros(
	
    id_membro CHAR(15) NOT NULL PRIMARY KEY,
    cpf CHAR(14) NOT NULL,
    nome  VARCHAR(80) NOT NULL,
    data_nascimento DATE NOT NULL,
    idade INTEGER NOT NULL,
    genero CHAR(1) NOT NULL,
    email varchar(80),
    fone varchar(15),
    cep CHAR(9) NOT NULL,
    endereco VARCHAR(80) NOT NULL,
    cidade VARCHAR(80) NOT NULL,
    bairro VARCHAR(80) NOT NULL,
    numero INTEGER,
    complemento VARCHAR(50),
    data_membramento DATE NOT NULL,
    data_batismo DATE NOT NULL,
    data_conversao DATE,
    status_membro CHAR(2) NOT NULL,
    data_falecimento DATE,
    id_funcao INTEGER NOT NULL,
	caminho_foto VARCHAR(80),
    
    FOREIGN KEY (status_membro) REFERENCES status_membros(id_status),
    FOREIGN KEY (id_funcao) REFERENCES funcoes(id_funcao)
    
);

DROP TABLE IF EXISTS financas;
CREATE TABLE financas(
	id_financa INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	id_membro char(15),
	descricao VARCHAR(128),
	categoria_financa CHAR(2) NOT NULL,
	tipo_financa CHAR(2) NOT NULL,
	valor NUMERIC(10,2) NOT NULL,
	data DATE NOT NULL,

	FOREIGN KEY (id_membro) REFERENCES membros(id_membro),
	FOREIGN KEY (categoria_financa) REFERENCES categorias_financas(id_categoria),
	FOREIGN KEY (tipo_financa) REFERENCES tipos_financas(id_tipo)

);

DROP TABLE IF EXISTS pendencias;
CREATE TABLE pendencias(
	id_pendencia INT IDENTITY(1,1) PRIMARY KEY,
    id_setor_destino CHAR(2) NOT NULL,
	titulo VARCHAR(128) NOT NULL,
	descricao VARCHAR(256),
    data_criacao DATE NOT NULL,
    data_resolucao DATE,
    status_pendencia CHAR(2) NOT NULL,
    id_urgencia INTEGER NOT NULL,
    nome_usuario VARCHAR(20),
    id_membro CHAR(15),
    
    FOREIGN KEY (id_setor_destino) REFERENCES setores(id_setor),
    FOREIGN KEY (id_urgencia) REFERENCES urgencias(id_urgencia),
    FOREIGN KEY (nome_usuario) REFERENCES usuarios(nome_usuario),
    FOREIGN KEY (id_membro) REFERENCES membros(id_membro),
    FOREIGN KEY (status_pendencia) REFERENCES status_pendencias(id_status)
);

-- População do Banco com Dados fixos
-- Inserções Tabela "status_pendencias"
INSERT INTO status_pendencias VALUES ('RE', 'RESOLVIDO'),
                                     ('PE', 'PENDENTE'),
                                     ('FE', 'FECHADO');
                                     
-- Inserções Tabela "status_usuarios"
INSERT INTO status_usuarios VALUES ('AT', 'ATIVO'),
								   ('IN', 'INATIVO'),
                                   ('PE', 'PENDENTE');
                                   
-- Inserções Tabela "status_membros"
INSERT INTO status_membros VALUES ('AT', 'ATIVO'),
								  ('DE', 'DESLIGADO'),
                                  ('FA', 'FALECIDO');

-- Inserções Tabela "urgencias"
INSERT INTO urgencias VALUES (1, 'POUQUÍSIMA URGÊNCIA'),
							 (2, 'POUCA URGÊNCIA'),
                             (3, 'MÉDIA URGÊNCIA'),
                             (4, 'GRAVE URGÊNCIA'),
                             (5, 'GRAVÍSSIMA URGÊNCIA');

-- Inserções Tabela "setores"
INSERT INTO setores VALUES ('PA', 'PASTORAL'),
						   ('SE', 'SECRETARIA'),
                           ('TE', 'TESOURARIA');

-- Inserções Tabela "funcoes"
INSERT INTO funcoes VALUES (1, 'PASTOR'),
						   (2, 'SECRETÁRIO'),
                           (3, 'TESOUREIRO'),
                           (4, 'LÍDER DOS JOVENS'),
                           (5, 'LÍDER DAS IRMÃS'),
                           (6, 'PROFESSOR DE ESCOLA BÍBLICA'),
                           (7, 'PORTEIRO'),
                           (8, 'FAXINEIRO'),
                           (9, 'PEDREIRO'),
						   (10,'MEMBRO');

-- Inserções Tabela "tipo_financas"
INSERT INTO tipos_financas VALUES ('EN', 'ENTRADAS'),
								  ('SA', 'SAÍDAS');

-- Inserção Tabela "categorias_financas"
INSERT INTO categorias_financas VALUES ('DÍ', 'EN', 'DÍZIMO'),
									   ('OF', 'EN', 'OFERTA'),
									   ('O.', 'EN', 'O. MISSIONÁRIA'),
									   ('EL','SA', 'ELETRICIDADE'),
									   ('ÁG','SA', 'ÁGUA');
