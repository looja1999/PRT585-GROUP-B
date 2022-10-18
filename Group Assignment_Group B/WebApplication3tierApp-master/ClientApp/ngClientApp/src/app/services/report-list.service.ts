import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ReportList } from '../models/report-list.model';

@Injectable({
  providedIn: 'root'
})
export class ReportListService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllReports(): Observable<ReportList[]> {
    return this.http.get<ReportList[]>(this.baseApiUrl + '/api/Report');
  }
}
