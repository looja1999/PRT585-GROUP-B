import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { GdReportList } from '../models/gdreport-list.model';

@Injectable({
  providedIn: 'root'
})
export class GdReportListService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllReports(): Observable<GdReportList[]> {
    return this.http.get<GdReportList[]>(this.baseApiUrl + '/api/GdReport');
  }
  addReport(addGdReportRequest: GdReportList): Observable<GdReportList> {
    addGdReportRequest.gdReportId = 0;
    return this.http.post<GdReportList>(this.baseApiUrl + '/api/GdReport', addGdReportRequest);
  }
  getReport(id: number): Observable<GdReportList> {
    return this.http.get<GdReportList>(this.baseApiUrl + '/api/GdReport/' + id);
  }

  updateReport(id: number, updatedReportRequest: GdReportList): Observable<GdReportList> {
    return this.http.put<GdReportList>(
      this.baseApiUrl + '/api/GdReport/' + id,
      updatedReportRequest
    );
  }

  deleteReport(id: number): Observable<GdReportList> {
    return this.http.delete<GdReportList>(this.baseApiUrl + '/api/GdReport/' + id);
  }
}
