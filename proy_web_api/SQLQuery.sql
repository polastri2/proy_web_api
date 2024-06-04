

CREATE TABLE dbo.usuarios (
    id INT NOT NULL,
    name char(200) NULL,
    document_number char(20) NULL,
    salary int NULL,
    age int NULL,
    profile char(20) NULL,
    admission_date DATE NULL
);


INSERT INTO usuarios 
select 1 id, 'Queren Esther Aguirre Pena' name, '11111111' document_number,1200 salary, 22 age, 'ingeniero' profile, CONVERT(DATE,'20/05/2020',103) admission_date union all
select 2 , 'Ruth Noemí Atoche Ynfante' , '11111112',1500 , 25, 'tecnico' ,  CONVERT(DATE,'20/05/2022',103) union all
select 3 , 'Martín Coronel Michilot' , '11111113',1600 , 23, 'obrero' ,  CONVERT(DATE,'20/05/2021',103) union all
select 4 , 'Yenni Coromoto Melendez Torres' , '11111114',1200 , 15, 'ingeniero' ,  CONVERT(DATE,'20/05/2020',103) union all
select 5 , 'Gabriela Marina Pulache Trigozo' , '11111115',1600 , 40, 'tecnico' ,  CONVERT(DATE,'20/05/2022',103) union all
select 6 , 'Juan Bleycker Silva Pretel' , '11111116',1500 , 20, 'obrero' ,  CONVERT(DATE,'20/05/2021',103) union all
select 7 , 'Lidia Aguilar Rivera' , '11111117',1800 , 18, 'ingeniero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 8 , 'Luzmer Eduardo Garcia Cordova' , '11111118',1800 , 20, 'tecnico' ,  CONVERT(DATE,'20/05/2022',103) union all
select 9 , 'Santos Isabel Sanchez Morrocho' , '11111119',1500 , 25, 'obrero' ,  CONVERT(DATE,'20/05/2021',103) union all
select 10 , 'Crystal Alejandra Alzamora Ramirez' , '11111120',1200 , 16, 'ingeniero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 11 , 'Carlos Teodomiro Arrese Lopez' , '11111121',2000 , 18, 'tecnico' ,  CONVERT(DATE,'20/05/2020',103) union all
select 12 , 'Ana Paula Cevasco Quintana' , '11111122',1800 , 19, 'obrero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 13 , 'Adexi Katerine Hernandez de Orellana' , '11111123',2000 , 23, 'ingeniero' ,  CONVERT(DATE,'20/05/2021',103) union all
select 14 , 'Claudia Catherine de Pozo' , '11111124',1600 , 28, 'tecnico' ,  CONVERT(DATE,'20/05/2022',103) union all
select 15 , 'Maria Angela Rosillo Zapata' , '11111125',1500 , 29, 'obrero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 16 , 'Fanny Villegas Seminario' , '11111126',1800 , 24, 'ingeniero' ,  CONVERT(DATE,'20/05/2021',103) union all
select 17 , 'Victor Raul Anasco Cumbicus' , '11111127',1200 , 20, 'tecnico' ,  CONVERT(DATE,'20/05/2020',103) union all
select 18 , 'Angel Faustino Castillo Talledo' , '11111128',1500 , 25, 'obrero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 19 , 'María Delaida de Castillo' , '11111129',1500 , 42, 'ingeniero' ,  CONVERT(DATE,'20/05/2022',103) union all
select 20 , 'Goldi Felicia Miranda del Rosario' , '11111130',1500 , 35, 'tecnico' ,  CONVERT(DATE,'20/05/2020',103) 


