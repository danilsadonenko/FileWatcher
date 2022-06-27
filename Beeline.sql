SELECT ClientName, MONTH(Date) as Month, SUM(Amount) as SumAmount FROM dbo.Supplies
  where YEAR(Date) = 2017
  group by ClientName, MONTH(Date)
  order by ClientName desc, Month(Date)