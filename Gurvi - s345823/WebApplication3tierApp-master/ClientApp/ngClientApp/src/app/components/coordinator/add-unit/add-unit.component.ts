import { Component, OnInit } from '@angular/core';
import { UnitList } from 'src/app/models/unit-list.model';
import { UnitListService } from 'src/app/services/unit-list.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-unit',
  templateUrl: './add-unit.component.html',
  styleUrls: ['./add-unit.component.less']
})
export class AddUnitComponent implements OnInit {
  errors: string[] = [];
  addUnitRequest: UnitList = {
    unitId: 0,
    unitName: '',
  };

  constructor(private unitlistService: UnitListService, private router: Router) {}

  ngOnInit(): void {
  }
  addUnit() {
    this.errors = [];
    console.log(this.addUnitRequest);
    this.unitlistService.addUnit(this.addUnitRequest).subscribe({
      next: (unitlists) => {
        console.log(unitlists);
        this.router.navigate(['unit']);
      },
      error: (msg) => {
        console.error(msg);
        this.errors.push(msg.error);
      },
    });
  }

}
