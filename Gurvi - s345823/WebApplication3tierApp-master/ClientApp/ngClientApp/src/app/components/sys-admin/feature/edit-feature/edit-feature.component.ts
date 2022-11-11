import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Feature } from 'src/app/models/feature.model';
import { FeaturesService } from 'src/app/services/features.service';

@Component({
  selector: 'app-edit-feature',
  templateUrl: './edit-feature.component.html',
  styleUrls: ['./edit-feature.component.less']
})
export class EditFeatureComponent implements OnInit {

  featureDetails : Feature = {
    featureId : 0, 
    featureName : ""
  }

  constructor(
    private route: ActivatedRoute,
    private featuresService: FeaturesService,
    private router: Router) { 
    }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.featuresService.getFeature(id).subscribe({
            next: (data) => {
              console.log(data);
              this.featureDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateFeature(){
    this.featuresService
      .updateFeature(this.featureDetails.featureId, this.featureDetails)
      .subscribe({
        next: (res) => this.router.navigate(['feature']),
        error: (msg) => console.error(msg),
      });
  }

  deleteFeature(id: number){
    this.featuresService.deleteFeature(id).subscribe({
      next : res => this.router.navigate(['feature']), 
      error : err => console.error(err)
    })
  }

}
