import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ReportList } from 'src/app/models/report-list.model';
import { ReportListService } from 'src/app/services/report-list.service';

@Component({
  selector: 'app-edit-report',
  templateUrl: './edit-report.component.html',
  styleUrls: ['./edit-report.component.less']
})
export class EditReportComponent implements OnInit {
  reportDetails: ReportList = {
    reportId: 0,
    reportName: '',
  };
  constructor(
    private route: ActivatedRoute,
    private reportService: ReportListService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.reportService.getReport(id).subscribe({
            next: (data) => {
              console.log(data);
              this.reportDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateReport() {
    this.reportService
      .updateReport(this.reportDetails.reportId, this.reportDetails)
      .subscribe({
        next: (res) => this.router.navigate(['report']),
        error: (msg) => console.error(msg),
      });
  }

  deleteReport(id: number) {
    this.reportService.deleteReport(id).subscribe({
      next: (res) => this.router.navigate(['report']),
    });
  }

}
