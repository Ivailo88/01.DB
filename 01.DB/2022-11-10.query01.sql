select `department_id`, `name`
from departments
where department_id >=1 AND department_id <=3;

select `department_id`, `name`
from departments
where department_id BETWEEN 1 AND 3;

select `department_id`, `name`
from departments 
where department_id IN (1,2,3);