import { Component, OnInit } from '@angular/core';
import { ReportList } from 'src/app/models/report-list.model';
import { ReportListService } from 'src/app/services/report-list.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-report',
  templateUrl: './add-report.component.html',
  styleUrls: ['./add-report.component.less']
})
export class AddReportComponent implements OnInit {
  errors: string[] = [];
  addReportRequest: ReportList = {
    reportId: 0,
    reportName: '',
  };

  constructor(private reportlistService: ReportListService, private router: Router) {}

  ngOnInit(): void {
  }
  addReport() {
    this.errors = [];
    console.log(this.addReportRequest);
    this.reportlistService.addReport(this.addReportRequest).subscribe({
      next: (reportlists) => {
        console.log(reportlists);
        this.router.navigate(['report']);
      },
      error: (msg) => {
        console.error(msg);
        this.errors.push(msg.error);
      },
    });
  }
}
