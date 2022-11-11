import { Component, OnInit } from '@angular/core';
import { GReportList } from 'src/app/models/greport-list.model';
import { GReportListService } from 'src/app/services/greport-list.service';

@Component({
  selector: 'app-greport-list',
  templateUrl: './greport-list.component.html',
  styleUrls: ['./greport-list.component.less']
})
export class GReportListComponent implements OnInit {

  constructor(private greportlistService: GReportListService) {} 
  
  gReportLists:GReportList[] = []
  
  ngOnInit(): void {
    this.greportlistService.getAllReports().subscribe({
      next: (gReportLists) => {
        console.log(gReportLists)
        this.gReportLists = gReportLists;
      },
    });
    console.log(this.gReportLists)
  }

}
