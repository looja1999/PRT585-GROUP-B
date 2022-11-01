import { IonButton, IonButtons, IonCard, IonCardContent, IonCardHeader, IonCardSubtitle, IonCardTitle, IonCol, IonContent, IonGrid, IonHeader, IonMenuButton, IonPage, IonReorder, IonReorderGroup, IonRouterLink, IonRow, IonSearchbar, IonText, IonTitle, IonToolbar, ItemReorderEventDetail } from '@ionic/react';
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

  // const { name } = useParams<{ name: string; }>();

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
                      <IonCard style={{width : "100%"}} color="tertiary">
                        <IonCardHeader>
                          <IonCardTitle>Roles</IonCardTitle>
                          <IonCardSubtitle>Total Roles number of available : 10</IonCardSubtitle>
                        </IonCardHeader>
                        <IonButton fill="clear" color="light" routerLink="/page/roles"> 
                          More Info
                        </IonButton>
                      </IonCard>
                  </IonRow>

                  <IonRow>
                    <IonCard  style={{width : "100%"}} color="success" >
                      <IonCardHeader>
                        <IonCardTitle>Features</IonCardTitle>
                        <IonCardSubtitle>Total Features number of available : 20</IonCardSubtitle>
                        </IonCardHeader>
                        <IonButton fill="clear" color="light"> 
                          <a style={{color: "white"}}> More Info </a>
                        </IonButton>
                      </IonCard>
                  </IonRow>
            </IonGrid>

            
          
        </IonContent>


      </IonContent>

    </IonPage>
  );
};

export default Dashboard;
