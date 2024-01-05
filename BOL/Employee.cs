using System.Data.Common;

namespace BOL;

public class Employee
{
    public int eid {get;set;}
    public string ename{get;set;}

    public string edate{get;set;}

    public string edescription{get;set;}

    public int ehours{get;set;}

    public string estatus{get;set;}

    public Employee(){

    }

    public Employee(int eid,string ename,string edate,string edescription,int ehours,string status){
        this.eid=eid;
        this.ename=ename;
        this.edate=edate;
        this.edescription=edescription;
        this.ehours=ehours;
        this.estatus=estatus;
    }

}
