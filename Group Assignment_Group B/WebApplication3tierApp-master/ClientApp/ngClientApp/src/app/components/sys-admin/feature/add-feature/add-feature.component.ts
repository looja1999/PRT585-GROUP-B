import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Feature } from 'src/app/models/feature.model';
import { FeaturesService } from 'src/app/services/features.service';

@Component({
  selector: 'app-add-feature',
  templateUrl: './add-feature.component.html',
  styleUrls: ['./add-feature.component.less'],
})
export class AddFeatureComponent implements OnInit {
  addFeatureRequest: Feature = {
    featureId: 0,
    featureName: '',
  };

  constructor(
    private featuresService: FeaturesService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  addFeature() {
    this.featuresService.addFeature(this.addFeatureRequest).subscribe({
      next: (res) => {
        this.router.navigate(['feature']);
        console.log(res);
      },
      error: (err) => console.error(err),
    });
  }
}
