import { Component, OnInit } from '@angular/core';
import { Feature } from 'src/app/models/feature.model';
import { FeaturesService } from 'src/app/services/features.service';

@Component({
  selector: 'app-feature',
  templateUrl: './feature.component.html',
  styleUrls: ['./feature.component.less']
})
export class FeatureComponent implements OnInit {

  features: Feature[] = [
    // Only for testing purpose. 
   {
    featureId : 1, 
    featureName : "Feature 1"
   }, 
   {
    featureId : 2, 
    featureName : "Feature 2"
   }
  ];
  constructor(private featuresService : FeaturesService) { }

  ngOnInit(): void {
    this.featuresService.getAllFeatures().subscribe({
      next : response => this.features = response,
      error : error => console.error(error)
    })
  }

}
