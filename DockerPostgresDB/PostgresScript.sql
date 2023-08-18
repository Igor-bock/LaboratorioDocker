\connect temporario

CREATE TABLE IF NOT EXISTS Produto(
    cd_codigo SERIAL PRIMARY KEY,
    ds_nome VARCHAR(99),
    vl_preco DECIMAL(10, 2)
);

INSERT INTO Produto VALUES (ds_nome, vl_preco)
('ProdutoTeste1', 654.92),
('TESTEProduto2', 891.87);
