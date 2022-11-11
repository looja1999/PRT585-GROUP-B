import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GdReportList } from 'src/app/models/gdreport-list.model';
import { GdReportListService } from 'src/app/services/gdreport-list.service';

@Component({
  selector: 'app-edit-gdreport',
  templateUrl: './edit-gdreport.component.html',
  styleUrls: ['./edit-gdreport.component.less']
})
export class EditGdReportComponent implements OnInit {
  gdreportDetails: GdReportList = {
    gdReportId: 0,
    gdReportName: '',
  };
  constructor(
    private route: ActivatedRoute,
    private gdreportService: GdReportListService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.gdreportService.getReport(id).subscribe({
            next: (data) => {
              console.log(data);
              this.gdreportDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateGdReport() {
    this.gdreportService
      .updateReport(this.gdreportDetails.gdReportId, this.gdreportDetails)
      .subscribe({
        next: (res) => this.router.navigate(['gdreport']),
        error: (msg) => console.error(msg),
      });
  }

  deleteGdReport(id: number) {
    this.gdreportService.deleteReport(id).subscribe({
      next: (res) => this.router.navigate(['gdreport']),
    });
  }

}
