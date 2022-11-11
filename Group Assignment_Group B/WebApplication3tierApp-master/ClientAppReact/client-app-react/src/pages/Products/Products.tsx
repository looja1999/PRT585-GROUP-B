import * as React from "react";
import 'hammerjs';
import { PDFExport, savePDF } from "@progress/kendo-react-pdf";
import { Grid, GridColumn as Column } from "@progress/kendo-react-grid";
import {
    Chart,
    ChartLegend,
    ChartSeries,
    ChartSeriesItem,
    ChartSeriesLabels,
    ChartCategoryAxis,
    ChartCategoryAxisItem
} from "@progress/kendo-react-charts";

import products from "./products.json";
import data from "./power-distribution-data.json";
import { IonContent } from "@ionic/react";

const labelContent = (e : any) => e.category;

const categories = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"];
const firstSeries = [123, 276, 310, 212, 240, 156, 98];
const secondSeries = [165, 210, 287, 144, 190, 167, 212];
const thirdSeries = [56, 140, 195, 46, 123, 78, 95];

const Products = () => {
  
  const container = React.useRef<HTMLDivElement>(null);
  const pdfExportComponent = React.useRef<PDFExport>(null);
  const exportPDFWithMethod = () => {
    let element = container.current || document.body;
    savePDF(element, {
        paperSize: "auto",
        margin: 40,
        fileName: `Report for ${new Date().getFullYear()}`
    });
  };
  const exportPDFWithComponent = () => {
    if(pdfExportComponent.current){
      pdfExportComponent.current.save();
    }
  };

  return (
    <IonContent className = "content-padding">
      <div>
        <div className="example-config">
          <button className="k-button k-button-md k-rounded-md k-button-solid k-button-solid-base" onClick={exportPDFWithComponent}>
            Export with component
          </button>
                &nbsp;
          <button className="k-button k-button-md k-rounded-md k-button-solid k-button-solid-base" onClick={exportPDFWithMethod}>
            Export with method
          </button>
        </div>
        <div className="border rounded p-2">
          <PDFExport
            ref={pdfExportComponent}
            paperSize="auto"
            margin={40}
            fileName={`Report for ${new Date().getFullYear()}`}
            author="KendoReact Team"
                >
            <div ref={container}>
              <h3 className="text-center">Monthly report</h3>
              <hr className="k-hr" />
              <Grid
                style={{ maxHeight: "400px" }}
                data={products.slice(0, 5)}
                        >
                <Column field="ProductID" title="ID" width="40px" />
                <Column field="ProductName" title="Name" width="250px" />
                <Column field="Category.CategoryName" title="CategoryName" />
                <Column field="UnitPrice" title="Price" width="80px" />
                <Column field="UnitsInStock" title="In stock" width="80px" />
              </Grid>
              <div className="row">
                <div className="col-6">
                  <Chart>
                    <ChartSeries>
                      <ChartSeriesItem
                        type="donut"
                        data={data}
                        categoryField="kind"
                        field="share"
                                        >
                        <ChartSeriesLabels
                          color="#fff"
                          background="none"
                          content={labelContent}
                                            />
                      </ChartSeriesItem>
                    </ChartSeries>
                    <ChartLegend visible={false} />
                  </Chart>
                </div>
                <div className="col-6">
                  <Chart>
                    <ChartCategoryAxis>
                      <ChartCategoryAxisItem categories={categories} />
                    </ChartCategoryAxis>
                    <ChartSeries>
                      <ChartSeriesItem type="area" data={firstSeries} />
                      <ChartSeriesItem type="area" data={secondSeries} />
                      <ChartSeriesItem type="area" data={thirdSeries} />
                    </ChartSeries>
                  </Chart>
                </div>
              </div>
            </div>
          </PDFExport>
        </div>
      </div>
    </IonContent>
  );
}


export default Products; 