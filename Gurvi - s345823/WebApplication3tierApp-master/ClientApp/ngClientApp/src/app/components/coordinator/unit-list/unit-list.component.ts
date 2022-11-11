import { Component, OnInit } from '@angular/core';
import { UnitList } from 'src/app/models/unit-list.model';
import { UnitListService } from 'src/app/services/unit-list.service';

@Component({
  selector: 'app-unit-list',
  templateUrl: './unit-list.component.html',
  styleUrls: ['./unit-list.component.less']
})
export class UnitListComponent implements OnInit {

  constructor(private unitlistService: UnitListService) {}

  unitlist: UnitList[] = []

  ngOnInit(): void {
    this.unitlistService.getAllUnits().subscribe({
      next: (unitlist) => {
        this.unitlist = unitlist;
        console.log(unitlist);
      },
    });
  }

}
