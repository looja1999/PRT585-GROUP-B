import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CourseList } from '../models/course-list.model';


@Injectable({
  providedIn: 'root'
})
export class CourseListService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllCourses(): Observable<CourseList[]> {
    return this.http.get<CourseList[]>(this.baseApiUrl + '/api/Course');
  }
}
