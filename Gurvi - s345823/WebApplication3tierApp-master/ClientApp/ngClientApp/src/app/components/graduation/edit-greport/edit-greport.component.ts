import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GReportList } from 'src/app/models/greport-list.model';
import { GReportListService } from 'src/app/services/greport-list.service';

@Component({
  selector: 'app-edit-greport',
  templateUrl: './edit-greport.component.html',
  styleUrls: ['./edit-greport.component.less']
})
export class EditGReportComponent implements OnInit {
  greportDetails: GReportList = {
    gReportId: 0,
    gReportName: '',
  };
  constructor(
    private route: ActivatedRoute,
    private greportService: GReportListService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.greportService.getReport(id).subscribe({
            next: (data) => {
              console.log(data);
              this.greportDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateGReport() {
    this.greportService
      .updateReport(this.greportDetails.gReportId, this.greportDetails)
      .subscribe({
        next: (res) => this.router.navigate(['greport']),
        error: (msg) => console.error(msg),
      });
  }

  deleteGReport(id: number) {
    this.greportService.deleteReport(id).subscribe({
      next: (res) => this.router.navigate(['greport']),
    });
  }

}
