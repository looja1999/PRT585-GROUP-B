import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { GReportList } from '../models/greport-list.model';

@Injectable({
  providedIn: 'root'
})
export class GReportListService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllReports(): Observable<GReportList[]> {
    return this.http.get<GReportList[]>(this.baseApiUrl + '/api/GReport');
  }
  addReport(addGReportRequest: GReportList): Observable<GReportList> {
    addGReportRequest.gReportId = 0;
    return this.http.post<GReportList>(this.baseApiUrl + '/api/GReport', addGReportRequest);
  }
  getReport(id: number): Observable<GReportList> {
    return this.http.get<GReportList>(this.baseApiUrl + '/api/GReport/' + id);
  }

  updateReport(id: number, updatedReportRequest: GReportList): Observable<GReportList> {
    return this.http.put<GReportList>(
      this.baseApiUrl + '/api/GReport/' + id,
      updatedReportRequest
    );
  }

  deleteReport(id: number): Observable<GReportList> {
    return this.http.delete<GReportList>(this.baseApiUrl + '/api/GReport/' + id);
  }
}
