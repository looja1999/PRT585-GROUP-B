import { IonButtons, IonContent, IonHeader, IonMenuButton, IonPage, IonText, IonTitle, IonToast, IonToolbar } from '@ionic/react';
import './Products.css';
import products from "./products.json";
import {
  Grid,
  GridColumn,
  GridPageChangeEvent,
} from "@progress/kendo-react-grid";
import React, { useEffect, useState } from 'react';
import '@progress/kendo-theme-default/dist/all.css';

interface PageState {
  skip: number;
  take: number;
}

const initialDataState: PageState = { skip: 0, take: 10 };

const Products: React.FC = () => {

  const [page, setPage] = React.useState<PageState>(initialDataState);
  const [showToast, setShowToast] = useState(false);

  const pageChange = (event: GridPageChangeEvent) => {
    setPage(event.page);
  };

  useEffect(() => {
    setTimeout(() => {
      setShowToast(true)
    }, 2000)
  }, [])


  return (
    <IonPage>
      <IonHeader>
        <IonToolbar>
          <IonButtons slot="start">
            <IonMenuButton />
          </IonButtons>
          <IonTitle>Products</IonTitle>
        </IonToolbar>
      </IonHeader>

      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Products</IonTitle>
          </IonToolbar>
        </IonHeader>

        <IonContent className='content-padding'>
          <IonTitle>Products Table</IonTitle>
          <p style={{padding: "5px 20px"}}> Contains list of all Products 👇</p>
          <div style={{padding: "5px 20px"}}>
            <Grid
              style={{ height: "400px" }}
              data={products.slice(page.skip, page.take + page.skip)}
              skip={page.skip}
              take={page.take}
              total={products.length}
              pageable={true}
              onPageChange={pageChange}
            >
              <GridColumn field="ProductID" />
              <GridColumn field="ProductName" title="Product Name" />
              <GridColumn field="UnitPrice" title="Unit Price" />
            </Grid>
          </div>
        </IonContent>

        <IonToast
        isOpen={showToast}
        onDidDismiss={() => setShowToast(false)}
        message="Welcome to Products Page 😈 "
        duration={3000}
        />
      </IonContent>


    </IonPage>
  );
};

export default Products;
