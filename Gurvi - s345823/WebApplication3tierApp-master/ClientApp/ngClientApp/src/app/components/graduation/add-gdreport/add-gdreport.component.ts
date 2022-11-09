import { Component, OnInit } from '@angular/core';
import { GdReportList } from 'src/app/models/gdreport-list.model';
import { GdReportListService } from 'src/app/services/gdreport-list.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-gdreport',
  templateUrl: './add-gdreport.component.html',
  styleUrls: ['./add-gdreport.component.less']
})
export class AddGdReportComponent implements OnInit {
  errors: string[] = [];
  addGdReportRequest: GdReportList = {
    gdReportId: 0,
    gdReportName: '',
  };

  constructor(private gdreportlistService: GdReportListService, private router: Router) {}

  ngOnInit(): void {
  }
  addGdReport() {
   
    console.log(this.addGdReportRequest);
    this.gdreportlistService.addReport(this.addGdReportRequest).subscribe({
      next: (gdreportlists) => {
        console.log(gdreportlists);
        this.router.navigate(['gdreport']);
      },
      error: (msg) => {
        console.error(msg);
        this.errors.push(msg.error);
      },
    });
  }
}
