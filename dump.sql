-- Dump do banco de dados com as tabelas 

-- Criação da tabela solicitantes
CREATE TABLE solicitantes (
    id INT AUTO_INCREMENT PRIMARY KEY, 
    solicitante VARCHAR(255) NOT NULL, 
    register_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP, 
    cpf VARCHAR(255) NOT NULL, 
    ip VARCHAR(255) NOT NULL
);

-- Criação da tabela relatorios
CREATE TABLE relatorios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_solicitacao DATETIME NOT NULL,
    arbovirose VARCHAR(50) NOT NULL,
    semana_inicio INT NOT NULL,
    semana_termino INT NOT NULL,
    codigo_ibge VARCHAR(10) NOT NULL,
    municipio VARCHAR(255),
    solicitante_id INT NOT NULL,
    FOREIGN KEY (solicitante_id) REFERENCES solicitantes(id)
);
