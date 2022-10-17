import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Role } from '../models/role.model';

@Injectable({
  providedIn: 'root'
})
export class RolesService {

  baseApiUrl : string = environment.baseApiUrl; 

  constructor(private http : HttpClient) { }

  getAllRoles () : Observable<Role[]>{
    return this.http.get<Role[]>(this.baseApiUrl + '/roles')
  }


}
