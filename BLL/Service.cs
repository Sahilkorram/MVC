namespace BLL;

using System;
using BOL;
using DAL;


public class Service
{
    public static List<Employee> getalllist()
    {
        return DBManager.getalllist();
    }

    public static bool updateEmp(int eid, string ename, string edate, string edescription,int ehours,string estatus)
    {
        return DBManager.updateEmp(eid,ename,edate,edescription,ehours,estatus);
    }
}
