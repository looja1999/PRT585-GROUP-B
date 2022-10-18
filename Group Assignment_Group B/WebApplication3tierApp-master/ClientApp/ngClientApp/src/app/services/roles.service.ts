import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Role } from '../models/role.model';

@Injectable({
  providedIn: 'root',
})
export class RolesService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllRoles(): Observable<Role[]> {
    return this.http.get<Role[]>(this.baseApiUrl + '/api/role');
  }

  addRole(addRoleRequest: Role): Observable<Role> {
    addRoleRequest.roleId = 0;
    return this.http.post<Role>(this.baseApiUrl + '/api/role', addRoleRequest);
  }

  getRole(id: number): Observable<Role> {
    return this.http.get<Role>(this.baseApiUrl + '/api/role/' + id);
  }

  updateRole(id: number, updatedRoleRequest: Role): Observable<Role> {
    return this.http.put<Role>(
      this.baseApiUrl + '/api/role/' + id,
      updatedRoleRequest
    );
  }

  deleteRoles(id: number): Observable<Role> {
    return this.http.delete<Role>(this.baseApiUrl + '/api/Role/' + id);
  }
}
