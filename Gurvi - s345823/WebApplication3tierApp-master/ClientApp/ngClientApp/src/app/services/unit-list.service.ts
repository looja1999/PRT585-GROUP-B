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
  addUnit(addUnitRequest: UnitList): Observable<UnitList> {
    addUnitRequest.unitId = 0;
    return this.http.post<UnitList>(this.baseApiUrl + '/api/Unit', addUnitRequest);
  }
  getUnit(id: number): Observable<UnitList> {
    return this.http.get<UnitList>(this.baseApiUrl + '/api/Unit/' + id);
  }

  updateUnit(id: number, updatedUnitRequest: UnitList): Observable<UnitList> {
    return this.http.put<UnitList>(
      this.baseApiUrl + '/api/Unit/' + id,
      updatedUnitRequest
    );
  }

  deleteUnit(id: number): Observable<UnitList> {
    return this.http.delete<UnitList>(this.baseApiUrl + '/api/Unit/' + id);
  }
}
