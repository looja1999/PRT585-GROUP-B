import { Component, OnInit } from '@angular/core';
import { ReportList } from 'src/app/models/report-list.model';
import { ReportListService } from 'src/app/services/report-list.service';

@Component({
  selector: 'app-report-list',
  templateUrl: './report-list.component.html',
  styleUrls: ['./report-list.component.less']
})
export class ReportListComponent implements OnInit {

  constructor(private reportlistService: ReportListService) {} 
  
  reportlist:ReportList[] = []
  
  ngOnInit(): void {
    this.reportlistService.getAllReports().subscribe({
      next: (reportlist) => {
        this.reportlist = reportlist;
        console.log(reportlist);
      },
    });
  }

}
