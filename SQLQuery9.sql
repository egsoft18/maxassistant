use GENSHOES

select * from Job_Progress

500250400000

select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'

--lectura PLAN 1CTB CG2  PLAN 

update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
--
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250390000'

-- Lectura de Corte
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
--
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'

-- Lectura de Pre-FItting
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
--
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'

-- Lectura de Casing Booties/Leather
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
--
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'

-- Lectura de Linea
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'

-- Lectura de Final
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PLAN'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'BCDP'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'CG2'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = '1CTB'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'INPS'
update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
update Job_Progress set MOVDTE_14 = '2018-03-04 00:00:00' where ordnum_14 = '500250400000' and WRKCTR_14 = 'PACK1'
select * from GENSHOES.dbo.Job_Progress where ordnum_14 = '500250400000'


select OPRDES_14, sum(QTYCOM_14) from Job_Progress group by OPRDES_14