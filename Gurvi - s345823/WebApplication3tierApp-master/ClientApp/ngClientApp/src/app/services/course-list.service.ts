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
  addCourse(adCourseRequest: CourseList): Observable<CourseList> {
    adCourseRequest.courseId = 0;
    return this.http.post<CourseList>(this.baseApiUrl + '/api/Course', adCourseRequest);
  }
  getCourse(id: number): Observable<CourseList> {
    return this.http.get<CourseList>(this.baseApiUrl + '/api/Course/' + id);
  }

  updateCourse(id: number, updatedCourseRequest: CourseList): Observable<CourseList> {
    return this.http.put<CourseList>(
      this.baseApiUrl + '/api/Course/' + id,
      updatedCourseRequest
    );
  }

  deleteCourse(id: number): Observable<CourseList> {
    return this.http.delete<CourseList>(this.baseApiUrl + '/api/Course/' + id);
  }
}
