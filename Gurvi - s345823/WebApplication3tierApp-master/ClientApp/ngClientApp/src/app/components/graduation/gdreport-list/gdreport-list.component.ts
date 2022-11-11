import { Component, OnInit } from '@angular/core';
import { GdReportList } from 'src/app/models/gdreport-list.model';
import { GdReportListService } from 'src/app/services/gdreport-list.service';

@Component({
  selector: 'app-gdreport-list',
  templateUrl: './gdreport-list.component.html',
  styleUrls: ['./gdreport-list.component.less']
})
export class GdReportListComponent implements OnInit {

  constructor(private gdreportlistService: GdReportListService) {} 
  
  gdReportLists:GdReportList[] = []
  
  ngOnInit(): void {
    this.gdreportlistService.getAllReports().subscribe({
      next: (gdReportLists) => {
        console.log(gdReportLists)
        this.gdReportLists = gdReportLists;
      },
    });
    console.log(this.gdReportLists)
  }

}
