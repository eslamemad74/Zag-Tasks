--5
select emp_id , emp_name , coalesce(d.dept_name, 'Unassigned') as dept_name
from Employees 
left join Departments 
on Employees.dept_id = Departments.dept_id;

--6
select  Products.product_name, Suppliers.supplier_name
from Products 
left join Suppliers 
on Products.supplier_id = Suppliers.supplier_id
where Products.product_name LIKE '%Phone%';

--7
select concat(c.first_name, ' ', c.last_name) as full_name, order_id, amount
from Customers 
full outer join Orders 
on Customer.customer_id = Orders.customer_id;



