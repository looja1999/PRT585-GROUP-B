import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Feature } from '../models/feature.model';

@Injectable({
  providedIn: 'root',
})
export class FeaturesService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllFeatures(): Observable<Feature[]> {
    return this.http.get<Feature[]>(this.baseApiUrl + '/api/feature');
  }

  addFeature(addFeatureRequest: Feature): Observable<Feature> {
    addFeatureRequest.featureId = 0;
    console.log(addFeatureRequest);
    return this.http.post<Feature>(
      this.baseApiUrl + '/api/Feature',
      addFeatureRequest
    );
  }

  getFeature(id: number): Observable<Feature> {
    return this.http.get<Feature>(this.baseApiUrl + '/api/feature/' + id);
  }

  updateFeature(
    id: number,
    updatedFeatureRequest: Feature
  ): Observable<Feature> {
    console.log(updatedFeatureRequest);
    return this.http.put<Feature>(
      this.baseApiUrl + '/api/feature/' + id,
      updatedFeatureRequest
    );
  }

  deleteFeature(id: number): Observable<Feature> {
    return this.http.delete<Feature>(this.baseApiUrl + '/api/Feature/' + id);
  }
}
