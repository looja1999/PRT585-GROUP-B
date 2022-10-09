import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Employee } from '../models/employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseApirUrl: string = environment.baseApiUrl;  
  constructor(private http: HttpClient) { }

  getAllEmployees(): Observable<Employee[]> {
      return this.http.get<Employee[]>(this.baseApirUrl + 'api/employees')
  }

  addEmployee(addEmployeeRequest: Employee): Observable<Employee[]> {
    addEmployeeRequest.id = '00000000-0000-0000-0000-000000000000'
    return this.http.post<Employee[]>(this.baseApirUrl + 'api/employees', addEmployeeRequest);
  }

  getEmployee(id: string): Observable<Employee> {
    return this.http.get<Employee>(this.baseApirUrl + 'api/employees/' +  id)
  }

  updateEmployee(id: string, updateEmployeeRequest: Employee): Observable<Employee>{
    return this.http.put<Employee>(this.baseApirUrl + 'api/employees/' +  id, updateEmployeeRequest);
  }

  deleteEmployee(id: string): Observable<Employee>{
    return this.http.delete<Employee>(this.baseApirUrl + 'api/employees/' +  id);
  }
}
