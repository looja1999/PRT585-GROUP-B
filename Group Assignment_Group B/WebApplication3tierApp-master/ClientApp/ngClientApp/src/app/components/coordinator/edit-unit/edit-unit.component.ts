import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UnitList } from 'src/app/models/unit-list.model';
import { UnitListService } from 'src/app/services/unit-list.service';

@Component({
  selector: 'app-edit-unit',
  templateUrl: './edit-unit.component.html',
  styleUrls: ['./edit-unit.component.less']
})
export class EditUnitComponent implements OnInit {
  unitDetails: UnitList = {
    unitId: 0,
    unitName: '',
  };
  constructor(
    private route: ActivatedRoute,
    private unitService: UnitListService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.unitService.getUnit(id).subscribe({
            next: (data) => {
              console.log(data);
              this.unitDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateUnit() {
    this.unitService
      .updateUnit(this.unitDetails.unitId, this.unitDetails)
      .subscribe({
        next: (res) => this.router.navigate(['unit']),
        error: (msg) => console.error(msg),
      });
  }

  deleteUnit(id: number) {
    this.unitService.deleteUnit(id).subscribe({
      next: (res) => this.router.navigate(['unit']),
    });
  }

}
