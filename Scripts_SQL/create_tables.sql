-- Cadastro de Refeições
	-- Table: TipoRefeicao
	-- Column: Name (varchar 100)
CREATE TABLE TipoRefeicao (Nome varchar(100));


-- Registro das refeições
	-- Table: RegistroRefeicao
	-- Column: Id (int)
	-- Column: Name (varchar 50)
	-- Column: DataRealizado (dateTime)
	-- Column: Realizado (varchar 50)
CREATE TABLE RegistroRefeicoes (ID int, Nome varchar(50), DataRealizado DateTime, Realizado varchar(50));

-- Tipos de realizado
	-- Table: TipoRealizado
	-- Column: Nome (varchar50)
CREATE TABLE TipoRealizado (Nome varchar(50));