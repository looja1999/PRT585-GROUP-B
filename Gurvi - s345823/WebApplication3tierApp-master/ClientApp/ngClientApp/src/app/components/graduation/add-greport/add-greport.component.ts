import { Component, OnInit } from '@angular/core';
import { GReportList } from 'src/app/models/greport-list.model';
import { GReportListService } from 'src/app/services/greport-list.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-greport',
  templateUrl: './add-greport.component.html',
  styleUrls: ['./add-greport.component.less']
})
export class AddGReportComponent implements OnInit {
  errors: string[] = [];
  addGReportRequest: GReportList = {
    gReportId: 0,
    gReportName: '',
  };

  constructor(private greportlistService: GReportListService, private router: Router) {}

  ngOnInit(): void {
  }
  addGReport() {
   
    console.log(this.addGReportRequest);
    this.greportlistService.addReport(this.addGReportRequest).subscribe({
      next: (greportlists) => {
        console.log(greportlists);
        this.router.navigate(['greport']);
      },
      error: (msg) => {
        console.error(msg);
        this.errors.push(msg.error);
      },
    });
  }
}
