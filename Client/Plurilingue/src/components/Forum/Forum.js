//import liraries
import React, { Component } from 'react';
import { Text, StyleSheet, FlatList, Dimensions } from 'react-native';
import { Container, Header, Content, List, ListItem, Thumbnail, Left, Body, Right, Button } from 'native-base';

// create a component
class Forum extends Component {

  constructor(){
    super()
    this.state = {
       questions: []
    }
 }

 componentWillMount(){
    fetch('http://10.0.2.2:5000/v1/forum/GetQuestions')
    .then((response) => response.json())
    .then((responseJson) => {
      this.setState({
        questions: responseJson
      })
    })
  }

  viewQuestion(id,userId){
    fetch(`http://10.0.2.2:5000/v1/forum/${id}`)
    .then((response) => response.json())
    .then((responseJson) => {
      this.props.navigation.navigate('QuestionForm',{question: responseJson, userId: userId})
    })
  }

  render() {
    const { navigation } = this.props;
    const userId = navigation.getParam('userId');
      return (     
      <Container>
        <Content>
        <Button block danger style={styles.askQuestionBtn} onPress={() => this.props.navigation.navigate('NewTopicForm',{
          userId: userId
        })}>
            <Text style={styles.askQuestTxt}>Ask Question</Text>
        </Button>
          <List>
            <FlatList 
              data={this.state.questions}
              renderItem={({item}) => (
              <ListItem thumbnail>
                <Body>
                  <Text>{item.title}</Text>
                  <Text note numberOfLines={1}>Language: {item.language}</Text>
                  <Text>Asked by: {item.user.userName} </Text>
                </Body>
                <Right>
                  <Button transparent onPress={() => this.viewQuestion(item.id, userId)}>
                    <Text style={{color: '#0d62ff', fontWeight: 'bold', fontSize: 20}}>View</Text>
                  </Button>
                </Right>
              </ListItem>
              )}
              keyExtractor={(item, index) => index.toString()}
            />
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
