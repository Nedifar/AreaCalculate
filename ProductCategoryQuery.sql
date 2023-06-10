select 
	p.Name as ProductName,
	c.Name as CategoryName
from 
	Products as p
left join
	Categories as c
on
	p.IdCategory = c.IdCategory