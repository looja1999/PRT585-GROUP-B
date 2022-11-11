import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddGReportComponent } from './add-greport.component';

describe('AddGReportComponent', () => {
  let component: AddGReportComponent;
  let fixture: ComponentFixture<AddGReportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddGReportComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddGReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
