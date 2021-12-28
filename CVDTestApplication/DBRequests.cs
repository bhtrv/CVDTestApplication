
namespace CVDTestApplication
{
    class DBRequests
    {
        public static string salarySumByDepartmentsQuery()
        {
            /*return @"SELECT (SELECT dep.name FROM department dep WHERE dep.id = e.department_id) 'department name', 
                            SUM(e.salary) 'department salary (without chiefs)'
                      FROM employee e JOIN department d ON(e.department_id = d.id)
                    GROUP BY e.department_id";*/

            return @"SELECT (SELECT dep.name FROM department dep WHERE dep.id = e.department_id) 'department name', 
			                SUM(e.salary) 'department salary (without chiefs)',
			                SUM(e.salary)+IFNULL((SELECT e1.salary FROM employee e1 WHERE e1.id = (
										                SELECT IFNULL(e2.chief_id,0) FROM employee e2
										                WHERE e2.department_id = e.department_id
										                order by e2.chief_id
		 								                LIMIT 1)),0) 'department salary (with chiefs)'								  
  
                  FROM employee e JOIN department d ON (e.department_id = d.id)  
                GROUP BY e.department_id";
        }
        public static string maxSalaryDepartmentQuery()
        {
            return @"SELECT d.name 'department with the max salary'
                      FROM employee e JOIN department d ON (e.department_id = d.id)
                        WHERE e.salary = (SELECT MAX(salary) FROM employee)";
        }
        public static string chiefsSalariesQuery()
        {
            return @"SELECT e.name, e.salary FROM employee e
	                    WHERE e.id IN (SELECT distinct chief_id FROM employee
						               WHERE chief_id IS NOT NULL)
                     ORDER BY e.salary desc";
        }
    }
}