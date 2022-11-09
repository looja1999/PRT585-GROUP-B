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
  addReport(addReportRequest: ReportList): Observable<ReportList> {
    addReportRequest.reportId = 0;
    return this.http.post<ReportList>(this.baseApiUrl + '/api/Report', addReportRequest);
  }
  getReport(id: number): Observable<ReportList> {
    return this.http.get<ReportList>(this.baseApiUrl + '/api/Report/' + id);
  }

  updateReport(id: number, updatedReportRequest: ReportList): Observable<ReportList> {
    return this.http.put<ReportList>(
      this.baseApiUrl + '/api/Report/' + id,
      updatedReportRequest
    );
  }

  deleteReport(id: number): Observable<ReportList> {
    return this.http.delete<ReportList>(this.baseApiUrl + '/api/Report/' + id);
  }
}
