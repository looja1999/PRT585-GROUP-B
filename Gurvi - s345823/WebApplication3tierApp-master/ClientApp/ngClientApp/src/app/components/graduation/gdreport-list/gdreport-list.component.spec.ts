import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GdReportListComponent } from './gdreport-list.component';

describe('GdReportListComponent', () => {
  let component: GdReportListComponent;
  let fixture: ComponentFixture<GdReportListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GdReportListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GdReportListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
