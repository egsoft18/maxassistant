/****** Script for SelectTopNRows command from SSMS  ******/
SELECT prtnum_14, sum(qtyrem_14)
  FROM [GENSHOES].[dbo].[Job_Progress] where wrkctr_14 = 'PLAN' and prtnum_14 like '424%' group by prtnum_14

  SELECT *
  FROM [GENSHOES].[dbo].[Job_Progress]

    SELECT PRTNUM_10 , sum(ORGQTY_10)
  FROM [GENSHOES].[dbo].[Order_Master] where ORDREF_10 >1  group by [PRTNUM_10]

  select ORDREF_10 from Order_Master group by ORDREF_10 order by ORDREF_10 desc

select PRTNUM_10 from Order_Master where ORDREF_10 = '200001290101' group by ORDREF_10 order by ORDREF_10 desc

select ORDREF_10 as 'Order', UDFREF_10 as Ref from Order_Master where ORDREF_10 like '2' and UDFREF_10 = '3423619'

select ORDREF_10 as 'Order', UDFREF_10 as Ref from Order_Master where ORDREF_10 like '200001290101%' and UDFREF_10 = '3423619'