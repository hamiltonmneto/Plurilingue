//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { Container, Header, Content, List, ListItem, Thumbnail, Left, Body, Right, Button } from 'native-base';

// create a component
class Forum extends Component {
    render() {
        return (     
    <Container>
        <Content>
        <Button block danger style={styles.askQuestionBtn} onPress={() => this.props.navigation.navigate('NewTopicForm')}>
            <Text style={styles.askQuestTxt}>Ask Question</Text>
        </Button>
          <List>
            <ListItem thumbnail>
              <Body>
                <Text>TITULO TESTE</Text>
                <Text note numberOfLines={1}>TESTE TOPICO . .</Text>
              </Body>
              <Right>
                <Button transparent>
                  <Text style={{color: '#0d62ff', fontWeight: 'bold', fontSize: 20}}>View</Text>
                </Button>
              </Right>
            </ListItem>
          </List>
        </Content>
      </Container>

        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#fff',
    },
    askQuestionBtn:{
      left: 85,
      width: 250,
      marginTop: 10,
      marginBottom: 10,
    },
    askQuestTxt:{
        color: 'white',
        fontSize: 16,
        fontWeight: 'bold'
    }
});

//make this component available to the app
export default Forum;
