import { IonButton, IonButtons, IonCard, IonCardContent, IonCardHeader, IonCardSubtitle, IonCardTitle, IonCol, IonContent, IonGrid, IonHeader, IonMenuButton, IonPage, IonReorder, IonReorderGroup, IonRouterLink, IonRow, IonSearchbar, IonText, IonTitle, IonToast, IonToolbar, ItemReorderEventDetail } from '@ionic/react';
import { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import { Link } from 'react-router-dom';
import './Dashboard.css';

const Dashboard: React.FC = () => {

  function handleReorder(event: CustomEvent<ItemReorderEventDetail>) {
    // The `from` and `to` properties contain the index of the item
    // when the drag started and ended, respectively
    console.log('Dragged from index', event.detail.from, 'to', event.detail.to);

    // Finish the reorder and position the item in the DOM based on
    // where the gesture ended. This method can also be called directly
    // by the reorder group
    event.detail.complete();
  }

  const [showToast, setShowToast] = useState(false);

  // const { name } = useParams<{ name: string; }>();

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
          <IonTitle>Dashboard</IonTitle>
        </IonToolbar>
      </IonHeader>

      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Dashboard</IonTitle>
          </IonToolbar>
        </IonHeader>

        <IonContent className = "content-padding">
          <IonTitle style={{marginBottom : "10px"}}>Welcome, User</IonTitle>

            <IonGrid>
                  <IonRow>
                      <IonCol size="12" sizeSm='4'>
                        <IonCard style={{width : "90%"}} color="tertiary">
                          <IonCardHeader>
                            <IonCardTitle>Products</IonCardTitle>
                            <IonCardSubtitle>Total Products number of available : 10</IonCardSubtitle>
                          </IonCardHeader>
                          <IonButton fill="clear" color="light" routerLink="/page/products"> 
                            More Info
                          </IonButton>
                        </IonCard>
                      </IonCol>
                  </IonRow>
            </IonGrid>
          
        </IonContent>

        <IonToast
        isOpen={showToast}
        onDidDismiss={() => setShowToast(false)}
        message="Welcome to Admin Dashboard 🚀"
        duration={2000}
        />

      </IonContent>

    </IonPage>
  );
};

export default Dashboard;
