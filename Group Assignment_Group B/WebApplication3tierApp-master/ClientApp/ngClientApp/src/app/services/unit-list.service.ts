import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UnitList } from '../models/unit-list.model';

@Injectable({
  providedIn: 'root'
})
export class UnitListService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllUnits(): Observable<UnitList[]> {
    return this.http.get<UnitList[]>(this.baseApiUrl + '/api/Unit');
  }
}
